using Business.Abstract;
using Business.Helpers;
using Core.Utilities.Results;
using Entities.Concrete;
using PLC.Sharp7;

namespace Business.Services
{
    public class CalibrationService
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        readonly ICalibrationLimitService _calibrationManager;

        CalibrationLimit _calibrationLimit;

        List<double> _measurementValues = new List<double>();

        public CalibrationService(ICalibrationLimitService calibrationManager)
        {
            _calibrationManager = calibrationManager;
        }

        public IDataResult<Calibration> ZeroClaibration(string parameter)
        {
            _calibrationLimit = _calibrationManager.Get(c => c.Parameter == parameter).Data;

            var parameterValue = _sharp7Service.S71200.DB41.GetType().GetProperty(parameter);

            if (parameterValue != null)
            {
                var measurementValue = Convert.ToDouble(parameterValue.GetValue(_sharp7Service.S71200.DB41));

                _measurementValues.Add(measurementValue);

                return new SuccessDataResult<Calibration>(new Calibration
                {
                    Parameter = parameter,
                    ZeroRef = _calibrationLimit.ZeroRef,
                    ZeroMeas = measurementValue,
                    ZeroDiff = _calibrationLimit.ZeroRef - measurementValue,
                    ZeroStd = CalibrationServiceHelper.CalculateStd(_measurementValues),
                });
            }

            return new ErrorDataResult<Calibration>();
        }
    }
}
