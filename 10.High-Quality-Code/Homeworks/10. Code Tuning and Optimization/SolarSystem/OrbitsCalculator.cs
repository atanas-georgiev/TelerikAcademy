﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrbitsCalculator.cs" company="">
//   
// </copyright>
// <summary>
//   The orbits calculator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SolarSystem
{
    using System;
    using System.ComponentModel;
    using System.Windows.Threading;

    /// <summary>
    /// The orbits calculator.
    /// </summary>
    internal class OrbitsCalculator : INotifyPropertyChanged
    {
        /// <summary>
        /// The earth year.
        /// </summary>
        private const double EarthYear = 365.25;

        /// <summary>
        /// The earth rotation period.
        /// </summary>
        private const double EarthRotationPeriod = 1.0;

        /// <summary>
        /// The sun rotation period.
        /// </summary>
        private const double SunRotationPeriod = 25.0;

        /// <summary>
        /// The two pi.
        /// </summary>
        private const double TwoPi = Math.PI * 2;

        /// <summary>
        /// The _days per second.
        /// </summary>
        private double _daysPerSecond = 2;

        /// <summary>
        /// The _start days.
        /// </summary>
        private double _startDays;

        /// <summary>
        /// The _start time.
        /// </summary>
        private DateTime _startTime;

        /// <summary>
        /// The _timer.
        /// </summary>
        private DispatcherTimer _timer;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrbitsCalculator"/> class.
        /// </summary>
        public OrbitsCalculator()
        {
            this.EarthOrbitPositionX = this.EarthOrbitRadius;
            this.DaysPerSecond = 2;
        }

        /// <summary>
        /// Gets or sets the days per second.
        /// </summary>
        public double DaysPerSecond
        {
            get
            {
                return this._daysPerSecond;
            }

            set
            {
                this._daysPerSecond = value;
                this.Update("DaysPerSecond");
            }
        }

        /// <summary>
        /// Gets or sets the earth orbit radius.
        /// </summary>
        public double EarthOrbitRadius
        {
            get
            {
                return 40;
            }

            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        public double Days { get; set; }

        /// <summary>
        /// Gets or sets the earth rotation angle.
        /// </summary>
        public double EarthRotationAngle { get; set; }

        /// <summary>
        /// Gets or sets the sun rotation angle.
        /// </summary>
        public double SunRotationAngle { get; set; }

        /// <summary>
        /// Gets or sets the earth orbit position x.
        /// </summary>
        public double EarthOrbitPositionX { get; set; }

        /// <summary>
        /// Gets or sets the earth orbit position y.
        /// </summary>
        public double EarthOrbitPositionY { get; set; }

        /// <summary>
        /// Gets or sets the earth orbit position z.
        /// </summary>
        public double EarthOrbitPositionZ { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether reverse time.
        /// </summary>
        public bool ReverseTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paused.
        /// </summary>
        public bool Paused { get; set; }

        /// <summary>
        /// The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The start timer.
        /// </summary>
        public void StartTimer()
        {
            this._startTime = DateTime.Now;
            this._timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(10) };
            this._timer.Tick += this.OnTimerTick;
            this._timer.Start();
        }

        /// <summary>
        /// The stop timer.
        /// </summary>
        private void StopTimer()
        {
            this._timer.Stop();
            this._timer.Tick -= this.OnTimerTick;
            this._timer = null;
        }

        /// <summary>
        /// The pause.
        /// </summary>
        /// <param name="doPause">
        /// The do pause.
        /// </param>
        public void Pause(bool doPause)
        {
            if (doPause)
            {
                this.StopTimer();
            }
            else
            {
                this.StartTimer();
            }
        }

        /// <summary>
        /// The on timer tick.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            this.Days += (now - this._startTime).TotalMilliseconds * this.DaysPerSecond / 1000.0
                         * (this.ReverseTime ? -1 : 1);
            this._startTime = now;
            this.Update("Days");
            this.OnTimeChanged();
        }

        /// <summary>
        /// The on time changed.
        /// </summary>
        private void OnTimeChanged()
        {
            this.EarthPosition();
            this.EarthRotation();
            this.SunRotation();
        }

        /// <summary>
        /// The earth position.
        /// </summary>
        private void EarthPosition()
        {
            var angle = 2 * Math.PI * this.Days / EarthYear;
            this.EarthOrbitPositionX = this.EarthOrbitRadius * Math.Cos(angle);
            this.EarthOrbitPositionY = this.EarthOrbitRadius * Math.Sin(angle);
            this.Update("EarthOrbitPositionX");
            this.Update("EarthOrbitPositionY");
        }

        /// <summary>
        /// The earth rotation.
        /// </summary>
        private void EarthRotation()
        {
            for (double step = 0; step <= 360; step += 0.00005)
            {
                this.EarthRotationAngle = step * this.Days / EarthRotationPeriod;
            }

            this.Update("EarthRotationAngle");
        }

        /// <summary>
        /// The sun rotation.
        /// </summary>
        private void SunRotation()
        {
            this.SunRotationAngle = 360 * this.Days / SunRotationPeriod;
            this.Update("SunRotationAngle");
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        private void Update(string propertyName)
        {
            if (this.PropertyChanged == null)
            {
                return;
            }

            var args = new PropertyChangedEventArgs(propertyName);
            this.PropertyChanged(this, args);
        }
    }
}