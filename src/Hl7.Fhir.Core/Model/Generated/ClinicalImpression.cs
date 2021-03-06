﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Tue, Sep 22, 2015 20:02+1000 for FHIR v1.0.1
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A clinical assessment performed when planning treatments and management strategies for a patient
    /// </summary>
    [FhirType("ClinicalImpression", IsResource=true)]
    [DataContract]
    public partial class ClinicalImpression : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ClinicalImpression; } }
        [NotMapped]
        public override string TypeName { get { return "ClinicalImpression"; } }
        
        /// <summary>
        /// The workflow state of a clinical impression.
        /// </summary>
        [FhirEnumeration("ClinicalImpressionStatus")]
        public enum ClinicalImpressionStatus
        {
            /// <summary>
            /// The assessment is still on-going and results are not yet final.
            /// </summary>
            [EnumLiteral("in-progress")]
            InProgress,
            /// <summary>
            /// The assessment is done and the results are final.
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// This assessment was never actually done and the record is erroneous (e.g. Wrong patient).
            /// </summary>
            [EnumLiteral("entered-in-error")]
            EnteredInError,
        }
        
        [FhirType("ClinicalImpressionFindingComponent")]
        [DataContract]
        public partial class ClinicalImpressionFindingComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ClinicalImpressionFindingComponent"; } }
            
            /// <summary>
            /// Specific text or code for finding
            /// </summary>
            [FhirElement("item", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Item;
            
            /// <summary>
            /// Which investigations support finding
            /// </summary>
            [FhirElement("cause", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CauseElement
            {
                get { return _CauseElement; }
                set { _CauseElement = value; OnPropertyChanged("CauseElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CauseElement;
            
            /// <summary>
            /// Which investigations support finding
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Cause
            {
                get { return CauseElement != null ? CauseElement.Value : null; }
                set
                {
                    if(value == null)
                      CauseElement = null; 
                    else
                      CauseElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Cause");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClinicalImpressionFindingComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.CodeableConcept)Item.DeepCopy();
                    if(CauseElement != null) dest.CauseElement = (Hl7.Fhir.Model.FhirString)CauseElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ClinicalImpressionFindingComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClinicalImpressionFindingComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                if( !DeepComparable.Matches(CauseElement, otherT.CauseElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClinicalImpressionFindingComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                if( !DeepComparable.IsExactly(CauseElement, otherT.CauseElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ClinicalImpressionRuledOutComponent")]
        [DataContract]
        public partial class ClinicalImpressionRuledOutComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ClinicalImpressionRuledOutComponent"; } }
            
            /// <summary>
            /// Specific text of code for diagnosis
            /// </summary>
            [FhirElement("item", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Item;
            
            /// <summary>
            /// Grounds for elimination
            /// </summary>
            [FhirElement("reason", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ReasonElement
            {
                get { return _ReasonElement; }
                set { _ReasonElement = value; OnPropertyChanged("ReasonElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ReasonElement;
            
            /// <summary>
            /// Grounds for elimination
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Reason
            {
                get { return ReasonElement != null ? ReasonElement.Value : null; }
                set
                {
                    if(value == null)
                      ReasonElement = null; 
                    else
                      ReasonElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Reason");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClinicalImpressionRuledOutComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.CodeableConcept)Item.DeepCopy();
                    if(ReasonElement != null) dest.ReasonElement = (Hl7.Fhir.Model.FhirString)ReasonElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ClinicalImpressionRuledOutComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClinicalImpressionRuledOutComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                if( !DeepComparable.Matches(ReasonElement, otherT.ReasonElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClinicalImpressionRuledOutComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                if( !DeepComparable.IsExactly(ReasonElement, otherT.ReasonElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ClinicalImpressionInvestigationsComponent")]
        [DataContract]
        public partial class ClinicalImpressionInvestigationsComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ClinicalImpressionInvestigationsComponent"; } }
            
            /// <summary>
            /// A name/code for the set
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Record of a specific investigation
            /// </summary>
            [FhirElement("item", InSummary=true, Order=50)]
            [References("Observation","QuestionnaireResponse","FamilyMemberHistory","DiagnosticReport")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Item
            {
                get { if(_Item==null) _Item = new List<Hl7.Fhir.Model.ResourceReference>(); return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Item;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClinicalImpressionInvestigationsComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(Item != null) dest.Item = new List<Hl7.Fhir.Model.ResourceReference>(Item.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ClinicalImpressionInvestigationsComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClinicalImpressionInvestigationsComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClinicalImpressionInvestigationsComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// The patient being assessed
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=90)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// The clinician performing the assessment
        /// </summary>
        [FhirElement("assessor", InSummary=true, Order=100)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Assessor
        {
            get { return _Assessor; }
            set { _Assessor = value; OnPropertyChanged("Assessor"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Assessor;
        
        /// <summary>
        /// in-progress | completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus> _StatusElement;
        
        /// <summary>
        /// in-progress | completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// When the assessment occurred
        /// </summary>
        [FhirElement("date", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// When the assessment occurred
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Why/how the assessment was performed
        /// </summary>
        [FhirElement("description", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Why/how the assessment was performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Reference to last assessment
        /// </summary>
        [FhirElement("previous", Order=140)]
        [References("ClinicalImpression")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Previous
        {
            get { return _Previous; }
            set { _Previous = value; OnPropertyChanged("Previous"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Previous;
        
        /// <summary>
        /// General assessment of patient state
        /// </summary>
        [FhirElement("problem", InSummary=true, Order=150)]
        [References("Condition","AllergyIntolerance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Problem
        {
            get { if(_Problem==null) _Problem = new List<Hl7.Fhir.Model.ResourceReference>(); return _Problem; }
            set { _Problem = value; OnPropertyChanged("Problem"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Problem;
        
        /// <summary>
        /// Request or event that necessitated this assessment
        /// </summary>
        [FhirElement("trigger", Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Trigger
        {
            get { return _Trigger; }
            set { _Trigger = value; OnPropertyChanged("Trigger"); }
        }
        
        private Hl7.Fhir.Model.Element _Trigger;
        
        /// <summary>
        /// One or more sets of investigations (signs, symptions, etc.)
        /// </summary>
        [FhirElement("investigations", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionInvestigationsComponent> Investigations
        {
            get { if(_Investigations==null) _Investigations = new List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionInvestigationsComponent>(); return _Investigations; }
            set { _Investigations = value; OnPropertyChanged("Investigations"); }
        }
        
        private List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionInvestigationsComponent> _Investigations;
        
        /// <summary>
        /// Clinical Protocol followed
        /// </summary>
        [FhirElement("protocol", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri ProtocolElement
        {
            get { return _ProtocolElement; }
            set { _ProtocolElement = value; OnPropertyChanged("ProtocolElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _ProtocolElement;
        
        /// <summary>
        /// Clinical Protocol followed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Protocol
        {
            get { return ProtocolElement != null ? ProtocolElement.Value : null; }
            set
            {
                if(value == null)
                  ProtocolElement = null; 
                else
                  ProtocolElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Protocol");
            }
        }
        
        /// <summary>
        /// Summary of the assessment
        /// </summary>
        [FhirElement("summary", Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString SummaryElement
        {
            get { return _SummaryElement; }
            set { _SummaryElement = value; OnPropertyChanged("SummaryElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _SummaryElement;
        
        /// <summary>
        /// Summary of the assessment
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Summary
        {
            get { return SummaryElement != null ? SummaryElement.Value : null; }
            set
            {
                if(value == null)
                  SummaryElement = null; 
                else
                  SummaryElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Summary");
            }
        }
        
        /// <summary>
        /// Possible or likely findings and diagnoses
        /// </summary>
        [FhirElement("finding", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionFindingComponent> Finding
        {
            get { if(_Finding==null) _Finding = new List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionFindingComponent>(); return _Finding; }
            set { _Finding = value; OnPropertyChanged("Finding"); }
        }
        
        private List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionFindingComponent> _Finding;
        
        /// <summary>
        /// Diagnoses/conditions resolved since previous assessment
        /// </summary>
        [FhirElement("resolved", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Resolved
        {
            get { if(_Resolved==null) _Resolved = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Resolved; }
            set { _Resolved = value; OnPropertyChanged("Resolved"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Resolved;
        
        /// <summary>
        /// Diagnosis considered not possible
        /// </summary>
        [FhirElement("ruledOut", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionRuledOutComponent> RuledOut
        {
            get { if(_RuledOut==null) _RuledOut = new List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionRuledOutComponent>(); return _RuledOut; }
            set { _RuledOut = value; OnPropertyChanged("RuledOut"); }
        }
        
        private List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionRuledOutComponent> _RuledOut;
        
        /// <summary>
        /// Estimate of likely outcome
        /// </summary>
        [FhirElement("prognosis", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PrognosisElement
        {
            get { return _PrognosisElement; }
            set { _PrognosisElement = value; OnPropertyChanged("PrognosisElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PrognosisElement;
        
        /// <summary>
        /// Estimate of likely outcome
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Prognosis
        {
            get { return PrognosisElement != null ? PrognosisElement.Value : null; }
            set
            {
                if(value == null)
                  PrognosisElement = null; 
                else
                  PrognosisElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Prognosis");
            }
        }
        
        /// <summary>
        /// Plan of action after assessment
        /// </summary>
        [FhirElement("plan", Order=240)]
        [References("CarePlan","Appointment","CommunicationRequest","DeviceUseRequest","DiagnosticOrder","MedicationOrder","NutritionOrder","Order","ProcedureRequest","ProcessRequest","ReferralRequest","SupplyRequest","VisionPrescription")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Plan
        {
            get { if(_Plan==null) _Plan = new List<Hl7.Fhir.Model.ResourceReference>(); return _Plan; }
            set { _Plan = value; OnPropertyChanged("Plan"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Plan;
        
        /// <summary>
        /// Actions taken during assessment
        /// </summary>
        [FhirElement("action", Order=250)]
        [References("ReferralRequest","ProcedureRequest","Procedure","MedicationOrder","DiagnosticOrder","NutritionOrder","SupplyRequest","Appointment")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Action
        {
            get { if(_Action==null) _Action = new List<Hl7.Fhir.Model.ResourceReference>(); return _Action; }
            set { _Action = value; OnPropertyChanged("Action"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Action;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ClinicalImpression;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Assessor != null) dest.Assessor = (Hl7.Fhir.Model.ResourceReference)Assessor.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionStatus>)StatusElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(Previous != null) dest.Previous = (Hl7.Fhir.Model.ResourceReference)Previous.DeepCopy();
                if(Problem != null) dest.Problem = new List<Hl7.Fhir.Model.ResourceReference>(Problem.DeepCopy());
                if(Trigger != null) dest.Trigger = (Hl7.Fhir.Model.Element)Trigger.DeepCopy();
                if(Investigations != null) dest.Investigations = new List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionInvestigationsComponent>(Investigations.DeepCopy());
                if(ProtocolElement != null) dest.ProtocolElement = (Hl7.Fhir.Model.FhirUri)ProtocolElement.DeepCopy();
                if(SummaryElement != null) dest.SummaryElement = (Hl7.Fhir.Model.FhirString)SummaryElement.DeepCopy();
                if(Finding != null) dest.Finding = new List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionFindingComponent>(Finding.DeepCopy());
                if(Resolved != null) dest.Resolved = new List<Hl7.Fhir.Model.CodeableConcept>(Resolved.DeepCopy());
                if(RuledOut != null) dest.RuledOut = new List<Hl7.Fhir.Model.ClinicalImpression.ClinicalImpressionRuledOutComponent>(RuledOut.DeepCopy());
                if(PrognosisElement != null) dest.PrognosisElement = (Hl7.Fhir.Model.FhirString)PrognosisElement.DeepCopy();
                if(Plan != null) dest.Plan = new List<Hl7.Fhir.Model.ResourceReference>(Plan.DeepCopy());
                if(Action != null) dest.Action = new List<Hl7.Fhir.Model.ResourceReference>(Action.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ClinicalImpression());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ClinicalImpression;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Assessor, otherT.Assessor)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(Previous, otherT.Previous)) return false;
            if( !DeepComparable.Matches(Problem, otherT.Problem)) return false;
            if( !DeepComparable.Matches(Trigger, otherT.Trigger)) return false;
            if( !DeepComparable.Matches(Investigations, otherT.Investigations)) return false;
            if( !DeepComparable.Matches(ProtocolElement, otherT.ProtocolElement)) return false;
            if( !DeepComparable.Matches(SummaryElement, otherT.SummaryElement)) return false;
            if( !DeepComparable.Matches(Finding, otherT.Finding)) return false;
            if( !DeepComparable.Matches(Resolved, otherT.Resolved)) return false;
            if( !DeepComparable.Matches(RuledOut, otherT.RuledOut)) return false;
            if( !DeepComparable.Matches(PrognosisElement, otherT.PrognosisElement)) return false;
            if( !DeepComparable.Matches(Plan, otherT.Plan)) return false;
            if( !DeepComparable.Matches(Action, otherT.Action)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ClinicalImpression;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Assessor, otherT.Assessor)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(Previous, otherT.Previous)) return false;
            if( !DeepComparable.IsExactly(Problem, otherT.Problem)) return false;
            if( !DeepComparable.IsExactly(Trigger, otherT.Trigger)) return false;
            if( !DeepComparable.IsExactly(Investigations, otherT.Investigations)) return false;
            if( !DeepComparable.IsExactly(ProtocolElement, otherT.ProtocolElement)) return false;
            if( !DeepComparable.IsExactly(SummaryElement, otherT.SummaryElement)) return false;
            if( !DeepComparable.IsExactly(Finding, otherT.Finding)) return false;
            if( !DeepComparable.IsExactly(Resolved, otherT.Resolved)) return false;
            if( !DeepComparable.IsExactly(RuledOut, otherT.RuledOut)) return false;
            if( !DeepComparable.IsExactly(PrognosisElement, otherT.PrognosisElement)) return false;
            if( !DeepComparable.IsExactly(Plan, otherT.Plan)) return false;
            if( !DeepComparable.IsExactly(Action, otherT.Action)) return false;
            
            return true;
        }
        
    }
    
}
