/*
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;
using System.Reflection;
using ThinkGeo.MapSuite.Shapes;

namespace ThinkGeo.MapSuite.WpfDesktop.Extension
{
    /// <summary>
    /// This class represents the parameters passed in through the BuildingIndex
    /// event in ShapeFileFeatureSource class.
    /// </summary>
    /// <remarks>None</remarks>
    [Serializable]
    public class BuildingIndexCsvFeatureSourceEventArgs : EventArgs
    {
        [Obfuscation(Exclude = true)]
        private int recordCount;

        [Obfuscation(Exclude = true)]
        private int currentRecordIndex;

        [Obfuscation(Exclude = true)]
        private Feature currentFeature;

        [Obfuscation(Exclude = true)]
        private DateTime startProcessTime;

        [Obfuscation(Exclude = true)]
        private bool cancel;

        [Obfuscation(Exclude = true)]
        private string csvPathFileName;

        /// <summary>
        /// This is the default constructor of the event args.
        /// </summary>
        /// <remarks>If you use this constructor, you have to set the properties manually.</remarks>
        public BuildingIndexCsvFeatureSourceEventArgs()
            : this(0, 0, new Feature(), DateTime.Now, false, string.Empty)
        {
        }

        /// <summary>
        /// This is the constructor of the event args by passing the desired parameters.
        /// </summary>
        public BuildingIndexCsvFeatureSourceEventArgs(int recordCount, int currentRecordIndex, Feature currentFeature, DateTime startProcessTime, bool cancel)
            : this(recordCount, currentRecordIndex, currentFeature, startProcessTime, cancel, string.Empty)
        {
        }

        public BuildingIndexCsvFeatureSourceEventArgs(int recordCount, int currentRecordIndex, Feature currentFeature, DateTime startProcessTime, bool cancel, string shapePathFileName)
            : base()
        {
            this.recordCount = recordCount;
            this.currentRecordIndex = currentRecordIndex;
            this.currentFeature = currentFeature;
            this.startProcessTime = startProcessTime;
            this.cancel = cancel;
            this.csvPathFileName = shapePathFileName;
        }

        /// <summary>
        /// Gets the total record count to build rTree index.
        /// </summary>
        public int RecordCount
        {
            get { return recordCount; }
        }

        /// <summary>
        /// Gets the current record index for building rTree index.
        /// </summary>
        public int CurrentRecordIndex
        {
            get { return currentRecordIndex; }
        }

        /// <summary>
        /// Gets the current feature for building rTree index.
        /// </summary>
        public Feature CurrentFeature
        {
            get { return currentFeature; }
        }

        /// <summary>
        /// Gets the starting process time for building the index.
        /// </summary>
        public DateTime StartProcessTime
        {
            get { return startProcessTime; }
        }

        /// <summary>
        /// Gets or sets to see if we need to cancel the building index of current record.
        /// </summary>
        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }

        public string CsvPathFileName
        {
            get { return csvPathFileName; }
        }
    }
}