﻿//******************************************************************************************************
//  OutputStreamDevicePhasor.cs - Gbtc
//
//  Copyright © 2010, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  08/15/2011 - Aniket Salver
//       Generated original version of source code.
//  09/16/2011 - Mehulbhai P Thakkar
//       Fixed bug in Load() method.
//   09/19/2011 - Mehulbhai P Thakkar
//       Added OnPropertyChanged() on all properties to reflect changes on UI.
//       Fixed Load() and GetLookupList() static methods.
//  09/15/2012 - Aniket Salver 
//          Added paging and sorting technique. 
//
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using TimeSeriesFramework.UI;
using TVA.Data;
using System.Linq;

namespace openPDC.UI.DataModels
{
    /// <summary>
    /// Represents a record of <see cref="OutputStreamDevicePhasor"/> information as defined in the database.
    /// </summary>
    public class OutputStreamDevicePhasor : DataModelBase
    {
        #region [ Members ]

        private Guid m_nodeID;
        private int m_outputStreamDeviceID;
        private int m_id;
        private string m_label;
        private string m_type;
        private string m_phase;
        private int m_scalingValue;
        private int m_loadOrder;
        private string m_phasorType;
        private string m_phaseType;
        private DateTime m_createdOn;
        private string m_createdBy;
        private DateTime m_updatedOn;
        private string m_updatedBy;

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> NodeID.
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor NodeID is a required field, please provide value.")]
        public Guid NodeID
        {
            get
            {
                return m_nodeID;
            }
            set
            {
                m_nodeID = value;
                OnPropertyChanged("NodeID");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> OutputStreamDeviceID.
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor OutputStreamDeviceID is a required field, please provide value.")]
        public int OutputStreamDeviceID
        {
            get
            {
                return m_outputStreamDeviceID;
            }
            set
            {
                m_outputStreamDeviceID = value;
                OnPropertyChanged("OutputStreamDeviceID");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> ID.
        /// </summary>
        // Field is populated by database via auto-increment and has no screen interaction, so no validation attributes are applied
        [Required(ErrorMessage = "OutputStreamDevicePhasor ID is a required field, please provide value.")]
        public int ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
                OnPropertyChanged("ID");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> Label.
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor Label is a required field, please provide value.")]
        [StringLength(200, ErrorMessage = "OutputStreamDevicePhasor Label cannot exceed 200 characters.")]
        public string Label
        {
            get
            {
                return m_label;
            }
            set
            {
                m_label = value;
                OnPropertyChanged("Label");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> Type.
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor Type is a required field, please provide value.")]
        [DefaultValue("V")]
        public string Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> Phase.
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor Phase is a required field, please provide value.")]
        [DefaultValue("+")]
        public string Phase
        {
            get
            {
                return m_phase;
            }
            set
            {
                m_phase = value;
                OnPropertyChanged("Phase");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> ScalingValue .
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor ScalingValue  is a required field, please provide value.")]
        public int ScalingValue
        {
            get
            {
                return m_scalingValue;
            }
            set
            {
                m_scalingValue = value;
                OnPropertyChanged("ScalingValue");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> LoadOrder .
        /// </summary>
        [Required(ErrorMessage = "OutputStreamDevicePhasor LoadOrder  is a required field, please provide value.")]
        public int LoadOrder
        {
            get
            {
                return m_loadOrder;
            }
            set
            {
                m_loadOrder = value;
                OnPropertyChanged("LoadOrder");
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> PhasorType.
        /// </summary>        
        public string PhasorType
        {
            get
            {
                return m_phasorType;
            }
        }

        /// <summary>
        /// Gets or sets <see cref="OutputStreamDevicePhasor"/> PhaseType.
        /// </summary>        
        public string PhaseType
        {
            get
            {
                return m_phaseType;
            }
        }

        /// <summary>
        /// Gets or sets when the current <see cref="OutputStreamDevicePhasor"/> was created.
        /// </summary>
        // Field is populated by trigger and has no screen interaction, so no validation attributes are applied
        public DateTime CreatedOn
        {
            get
            {
                return m_createdOn;
            }
            set
            {
                m_createdOn = value;
            }
        }

        /// <summary>
        /// Gets or sets who the current <see cref="OutputStreamDevicePhasor"/> was created by.
        /// </summary>
        // Field is populated by trigger and has no screen interaction, so no validation attributes are applied
        public string CreatedBy
        {
            get
            {
                return m_createdBy;
            }
            set
            {
                m_createdBy = value;
            }
        }

        /// <summary>
        /// Gets or sets when the current <see cref="OutputStreamDevicePhasor"/> was updated.
        /// </summary>
        // Field is populated by trigger and has no screen interaction, so no validation attributes are applied
        public DateTime UpdatedOn
        {
            get
            {
                return m_updatedOn;
            }
            set
            {
                m_updatedOn = value;
            }
        }

        /// <summary>
        /// Gets or sets who the current <see cref="OutputStreamDevicePhasor"/> was updated by.
        /// </summary>
        // Field is populated by trigger and has no screen interaction, so no validation attributes are applied
        public string UpdatedBy
        {
            get
            {
                return m_updatedBy;
            }
            set
            {
                m_updatedBy = value;
            }
        }

        #endregion

        #region [Static]
        // Static Methods      

        /// <summary>
        /// LoadKeys <see cref="OutputStreamDevicePhasor"/> information as an <see cref="ObservableCollection{T}"/> style list.
        /// </summary>
        /// <param name="database"><see cref="AdoDataConnection"/> to connection to database.</param>
        /// <param name="outputStreamDeviceID">ID of the output stream device to filter data.</param>
        /// <param name="sortMember">The field to sort by.</param>
        /// <param name="sortDirection"><c>ASC</c> or <c>DESC</c> for ascending or descending respectively.</param>
        /// <returns>Collection of <see cref="OutputStreamDevicePhasor"/>.</returns>
        public static IList<int> LoadKeys(AdoDataConnection database, int outputStreamDeviceID, string sortMember, string sortDirection)
        {
            bool createdConnection = false;

            try
            {
                createdConnection = CreateConnection(ref database);

                IList<int> outputStreamDevicePhasorList = new List<int>();
                DataTable OutputStreamDevicePhasorTable;

                string sortClause = string.Empty;

                if (!string.IsNullOrEmpty(sortMember) || !string.IsNullOrEmpty(sortDirection))
                    sortClause = string.Format("ORDER BY {0} {1}", sortMember, sortDirection);

                OutputStreamDevicePhasorTable = database.Connection.RetrieveData(database.AdapterType, string.Format("SELECT ID FROM OutputStreamDevicePhasor WHERE ID IN = {1} {0}", sortClause, outputStreamDeviceID));

                foreach (DataRow row in OutputStreamDevicePhasorTable.Rows)
                {
                    outputStreamDevicePhasorList.Add((row.ConvertField<int>("ID")));
                }


                return outputStreamDevicePhasorList;
            }
            finally
            {
                if (createdConnection && database != null)
                    database.Dispose();
            }
        }

        /// <summary>
        /// Loads <see cref="OutputStreamDevicePhasor"/> information as an <see cref="ObservableCollection{T}"/> style list.
        /// </summary>
        /// <param name="database"><see cref="AdoDataConnection"/> to connection to database.</param>
        /// <param name="outputStreamDeviceID">ID of the output stream device to filter data.</param>
        /// <param name="Keys">Keys of the measuremnets to be loaded from the database</param>
        /// <returns>Collection of <see cref="OutputStreamDevicePhasor"/>.</returns>
        public static ObservableCollection<OutputStreamDevicePhasor> Load(AdoDataConnection database, int outputStreamDeviceID, IList<int> Keys)
        {
            bool createdConnection = false;

            try
            {
                createdConnection = CreateConnection(ref database);

                ObservableCollection<OutputStreamDevicePhasor> OutputStreamDevicePhasorList = new ObservableCollection<OutputStreamDevicePhasor>();
                DataTable OutputStreamDevicePhasorTable;
                string query;
                string commaSeparatedKeys;

                if ((object)Keys != null && Keys.Count > 0)
                {
                    commaSeparatedKeys = Keys.Select(key => "'" + key.ToString() + "'").Aggregate((str1, str2) => str1 + "," + str2);
                    query = database.ParameterizedQueryString(string.Format("SELECT NodeID, OutputStreamDeviceID, ID, Label, Type, Phase, ScalingValue, LoadOrder " +
                          "FROM OutputStreamDevicePhasor WHERE ID IN ({0}) AND OutputStreamDeviceID = {1} ", commaSeparatedKeys, outputStreamDeviceID));
                    OutputStreamDevicePhasorTable = database.Connection.RetrieveData(database.AdapterType, query);

                    foreach (DataRow row in OutputStreamDevicePhasorTable.Rows)
                    {
                        OutputStreamDevicePhasorList.Add(new OutputStreamDevicePhasor()
                        {
                            NodeID = row.ConvertField<Guid>("NodeID"),
                            OutputStreamDeviceID = row.ConvertField<int>("OutputStreamDeviceID"),
                            ID = row.ConvertField<int>("ID"),
                            Label = row.Field<string>("Label"),
                            Type = row.Field<string>("Type"),
                            Phase = row.Field<string>("Phase"),
                            ScalingValue = row.ConvertField<int>("ScalingValue"),
                            LoadOrder = row.ConvertField<int>("LoadOrder"),
                            m_phaseType = row.Field<string>("Phase") == "+" ? "Positive Sequence" : row.Field<string>("Phase") == "-" ? "Negative Sequence" :
                                                                    row.Field<string>("Phase") == "0" ? "Zero Sequence" : row.Field<string>("Phase") == "A" ? "Phase A" :
                                                                    row.Field<string>("Phase") == "B" ? "Phase B" : "Phase C",
                            m_phasorType = row.Field<string>("Type") == "V" ? "Voltage" : "Current"
                        });
                    }
                }
                return OutputStreamDevicePhasorList;
            }
            finally
            {
                if (createdConnection && database != null)
                    database.Dispose();
            }
        }

        /// <summary>
        /// Gets a <see cref="Dictionary{T1,T2}"/> style list of <see cref="OutputStreamDevicePhasor"/> information.
        /// </summary>
        /// <param name="database"><see cref="AdoDataConnection"/> to connection to database.</param>
        /// <param name="outputStreamDeviceID">ID of the output stream device to filter data.</param>
        /// <param name="isOptional">Indicates if selection on UI is optional for this collection.</param>
        /// <returns><see cref="Dictionary{T1,T2}"/> containing ID and Label of OutputStreamDevicePhasors defined in the database.</returns>
        public static Dictionary<int, string> GetLookupList(AdoDataConnection database, int outputStreamDeviceID, bool isOptional = false)
        {
            bool createdConnection = false;
            try
            {
                createdConnection = CreateConnection(ref database);

                Dictionary<int, string> OutputStreamDevicePhasorList = new Dictionary<int, string>();
                if (isOptional)
                    OutputStreamDevicePhasorList.Add(0, "Select OutputStreamDevicePhasor");

                string query = database.ParameterizedQueryString("SELECT ID, Label FROM OutputStreamDevicePhasor " +
                    "WHERE OutputStreamDeviceID = {0} ORDER BY LoadOrder", "outputStreamDeviceID");
                DataTable OutputStreamDevicePhasorTable = database.Connection.RetrieveData(database.AdapterType, query, DefaultTimeout, outputStreamDeviceID);

                foreach (DataRow row in OutputStreamDevicePhasorTable.Rows)
                    OutputStreamDevicePhasorList[row.ConvertField<int>("ID")] = row.Field<string>("Label");

                return OutputStreamDevicePhasorList;
            }
            finally
            {
                if (createdConnection && database != null)
                    database.Dispose();
            }
        }

        /// <summary>
        /// Saves <see cref="OutputStreamDevicePhasor"/> information to database.
        /// </summary>
        /// <param name="database"><see cref="AdoDataConnection"/> to connection to database.</param>
        /// <param name="outputStreamDevicePhasor">Information about <see cref="OutputStreamDevicePhasor"/>.</param>        
        /// <returns>String, for display use, indicating success.</returns>
        public static string Save(AdoDataConnection database, OutputStreamDevicePhasor outputStreamDevicePhasor)
        {
            bool createdConnection = false;
            string query;

            try
            {
                createdConnection = CreateConnection(ref database);

                if (outputStreamDevicePhasor.ID == 0)
                {
                    query = database.ParameterizedQueryString("INSERT INTO OutputStreamDevicePhasor (NodeID, OutputStreamDeviceID, Label, Type, Phase, ScalingValue, " +
                        "LoadOrder, UpdatedBy, UpdatedOn, CreatedBy, CreatedOn) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", "nodeID",
                        "outputStreamDeviceID", "label", "type", "phase", "scalingValue", "loadOrder", "updatedBy", "updatedOn", "createdBy", "createdOn");

                    database.Connection.ExecuteNonQuery(query, DefaultTimeout, database.CurrentNodeID(), outputStreamDevicePhasor.OutputStreamDeviceID,
                        outputStreamDevicePhasor.Label, outputStreamDevicePhasor.Type, outputStreamDevicePhasor.Phase, outputStreamDevicePhasor.ScalingValue,
                        outputStreamDevicePhasor.LoadOrder, CommonFunctions.CurrentUser, database.UtcNow(), CommonFunctions.CurrentUser, database.UtcNow());

                    //    PhasorType, PhaseType @phasorName, @phaseType, OutputStreamDevicePhasor.PhasorType, OutputStreamDevicePhasor.PhaseType
                }
                else
                {
                    query = database.ParameterizedQueryString("UPDATE OutputStreamDevicePhasor SET NodeID = {0}, OutputStreamDeviceID = {1}, Label = {2}, Type = {3}, " +
                        "Phase = {4}, ScalingValue = {5}, LoadOrder = {6}, UpdatedBy = {7}, UpdatedOn = {8} WHERE ID = {9}", "nodeID", "outputStreamDeviceID", "label",
                        "type", "phase", "scalingValue", "loadOrder", "updatedBy", "updatedOn", "id");

                    database.Connection.ExecuteNonQuery(query, DefaultTimeout, outputStreamDevicePhasor.NodeID, outputStreamDevicePhasor.OutputStreamDeviceID,
                        outputStreamDevicePhasor.Label, outputStreamDevicePhasor.Type, outputStreamDevicePhasor.Phase, outputStreamDevicePhasor.ScalingValue,
                        outputStreamDevicePhasor.LoadOrder, CommonFunctions.CurrentUser, database.UtcNow(), outputStreamDevicePhasor.ID);

                    //PhasorType = @typeName, PhaseType = @PhaseType" OutputStreamDevicePhasor.PhasorType, OutputStreamDevicePhasor.PhaseType,
                }

                return "OutputStreamDevicePhasor information saved successfully";
            }
            finally
            {
                if (createdConnection && database != null)
                    database.Dispose();
            }
        }

        /// <summary>
        /// Deletes specified <see cref="OutputStreamDevicePhasor"/> record from database.
        /// </summary>
        /// <param name="database"><see cref="AdoDataConnection"/> to connection to database.</param>
        /// <param name="OutputStreamDevicePhasorID">ID of the record to be deleted.</param>
        /// <returns>String, for display use, indicating success.</returns>
        public static string Delete(AdoDataConnection database, int OutputStreamDevicePhasorID)
        {
            bool createdConnection = false;

            try
            {
                createdConnection = CreateConnection(ref database);

                // Setup current user context for any delete triggers
                CommonFunctions.SetCurrentUserContext(database);

                database.Connection.ExecuteNonQuery(database.ParameterizedQueryString("DELETE FROM OutputStreamDevicePhasor WHERE ID = {0}", "outputStreamDevicePhasorID"), DefaultTimeout, OutputStreamDevicePhasorID);

                return "OutputStreamDevicePhasor deleted successfully";
            }
            finally
            {
                if (createdConnection && database != null)
                    database.Dispose();
            }
        }

        #endregion
    }
}
