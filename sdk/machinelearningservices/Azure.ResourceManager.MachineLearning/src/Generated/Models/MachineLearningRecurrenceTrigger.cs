// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningRecurrenceTrigger.
    /// Serialized Name: RecurrenceTrigger
    /// </summary>
    public partial class MachineLearningRecurrenceTrigger : MachineLearningTriggerBase
    {
        /// <summary> Initializes a new instance of MachineLearningRecurrenceTrigger. </summary>
        /// <param name="frequency">
        /// [Required] The frequency to trigger schedule.
        /// Serialized Name: RecurrenceTrigger.frequency
        /// </param>
        /// <param name="interval">
        /// [Required] Specifies schedule interval in conjunction with frequency
        /// Serialized Name: RecurrenceTrigger.interval
        /// </param>
        public MachineLearningRecurrenceTrigger(MachineLearningRecurrenceFrequency frequency, int interval)
        {
            Frequency = frequency;
            Interval = interval;
            TriggerType = MachineLearningTriggerType.Recurrence;
        }

        /// <summary> Initializes a new instance of MachineLearningRecurrenceTrigger. </summary>
        /// <param name="endTime">
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be &quot;2022-06-01T00:00:01&quot;
        /// If not present, the schedule will run indefinitely
        /// Serialized Name: TriggerBase.endTime
        /// </param>
        /// <param name="startTime">
        /// Specifies start time of schedule in ISO 8601 format, but without a UTC offset.
        /// Serialized Name: TriggerBase.startTime
        /// </param>
        /// <param name="timeZone">
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// Serialized Name: TriggerBase.timeZone
        /// </param>
        /// <param name="triggerType">
        /// [Required] 
        /// Serialized Name: TriggerBase.triggerType
        /// </param>
        /// <param name="frequency">
        /// [Required] The frequency to trigger schedule.
        /// Serialized Name: RecurrenceTrigger.frequency
        /// </param>
        /// <param name="interval">
        /// [Required] Specifies schedule interval in conjunction with frequency
        /// Serialized Name: RecurrenceTrigger.interval
        /// </param>
        /// <param name="schedule">
        /// The recurrence schedule.
        /// Serialized Name: RecurrenceTrigger.schedule
        /// </param>
        internal MachineLearningRecurrenceTrigger(string endTime, string startTime, string timeZone, MachineLearningTriggerType triggerType, MachineLearningRecurrenceFrequency frequency, int interval, MachineLearningRecurrenceSchedule schedule) : base(endTime, startTime, timeZone, triggerType)
        {
            Frequency = frequency;
            Interval = interval;
            Schedule = schedule;
            TriggerType = triggerType;
        }

        /// <summary>
        /// [Required] The frequency to trigger schedule.
        /// Serialized Name: RecurrenceTrigger.frequency
        /// </summary>
        public MachineLearningRecurrenceFrequency Frequency { get; set; }
        /// <summary>
        /// [Required] Specifies schedule interval in conjunction with frequency
        /// Serialized Name: RecurrenceTrigger.interval
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// The recurrence schedule.
        /// Serialized Name: RecurrenceTrigger.schedule
        /// </summary>
        public MachineLearningRecurrenceSchedule Schedule { get; set; }
    }
}
