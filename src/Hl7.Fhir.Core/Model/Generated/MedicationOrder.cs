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
    /// Prescription of medication to for patient
    /// </summary>
    [FhirType("MedicationOrder", IsResource=true)]
    [DataContract]
    public partial class MedicationOrder : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationOrder; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationOrder"; } }
        
        /// <summary>
        /// A code specifying the state of the prescribing event. Describes the lifecycle of the prescription.
        /// </summary>
        [FhirEnumeration("MedicationOrderStatus")]
        public enum MedicationOrderStatus
        {
            /// <summary>
            /// The prescription is 'actionable', but not all actions that are implied by it have occurred yet.
            /// </summary>
            [EnumLiteral("active")]
            Active,
            /// <summary>
            /// Actions implied by the prescription are to be temporarily halted, but are expected to continue later.  May also be called "suspended".
            /// </summary>
            [EnumLiteral("on-hold")]
            OnHold,
            /// <summary>
            /// All actions that are implied by the prescription have occurred.
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// The prescription was entered in error.
            /// </summary>
            [EnumLiteral("entered-in-error")]
            EnteredInError,
            /// <summary>
            /// Actions implied by the prescription are to be permanently halted, before all of them occurred.
            /// </summary>
            [EnumLiteral("stopped")]
            Stopped,
            /// <summary>
            /// The prescription is not yet 'actionable', i.e. it is a work in progress, requires sign-off or verification, and needs to be run through decision support process.
            /// </summary>
            [EnumLiteral("draft")]
            Draft,
        }
        
        [FhirType("MedicationOrderDispenseRequestComponent")]
        [DataContract]
        public partial class MedicationOrderDispenseRequestComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MedicationOrderDispenseRequestComponent"; } }
            
            /// <summary>
            /// Product to be supplied
            /// </summary>
            [FhirElement("medication", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Medication
            {
                get { return _Medication; }
                set { _Medication = value; OnPropertyChanged("Medication"); }
            }
            
            private Hl7.Fhir.Model.Element _Medication;
            
            /// <summary>
            /// Time period supply is authorized for
            /// </summary>
            [FhirElement("validityPeriod", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Period ValidityPeriod
            {
                get { return _ValidityPeriod; }
                set { _ValidityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
            }
            
            private Hl7.Fhir.Model.Period _ValidityPeriod;
            
            /// <summary>
            /// Number of refills authorized
            /// </summary>
            [FhirElement("numberOfRepeatsAllowed", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.PositiveInt NumberOfRepeatsAllowedElement
            {
                get { return _NumberOfRepeatsAllowedElement; }
                set { _NumberOfRepeatsAllowedElement = value; OnPropertyChanged("NumberOfRepeatsAllowedElement"); }
            }
            
            private Hl7.Fhir.Model.PositiveInt _NumberOfRepeatsAllowedElement;
            
            /// <summary>
            /// Number of refills authorized
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? NumberOfRepeatsAllowed
            {
                get { return NumberOfRepeatsAllowedElement != null ? NumberOfRepeatsAllowedElement.Value : null; }
                set
                {
                    if(value == null)
                      NumberOfRepeatsAllowedElement = null; 
                    else
                      NumberOfRepeatsAllowedElement = new Hl7.Fhir.Model.PositiveInt(value);
                    OnPropertyChanged("NumberOfRepeatsAllowed");
                }
            }
            
            /// <summary>
            /// Amount of medication to supply per dispense
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Number of days supply per dispense
            /// </summary>
            [FhirElement("expectedSupplyDuration", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Duration ExpectedSupplyDuration
            {
                get { return _ExpectedSupplyDuration; }
                set { _ExpectedSupplyDuration = value; OnPropertyChanged("ExpectedSupplyDuration"); }
            }
            
            private Hl7.Fhir.Model.Duration _ExpectedSupplyDuration;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MedicationOrderDispenseRequestComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Medication != null) dest.Medication = (Hl7.Fhir.Model.Element)Medication.DeepCopy();
                    if(ValidityPeriod != null) dest.ValidityPeriod = (Hl7.Fhir.Model.Period)ValidityPeriod.DeepCopy();
                    if(NumberOfRepeatsAllowedElement != null) dest.NumberOfRepeatsAllowedElement = (Hl7.Fhir.Model.PositiveInt)NumberOfRepeatsAllowedElement.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    if(ExpectedSupplyDuration != null) dest.ExpectedSupplyDuration = (Hl7.Fhir.Model.Duration)ExpectedSupplyDuration.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MedicationOrderDispenseRequestComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MedicationOrderDispenseRequestComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
                if( !DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if( !DeepComparable.Matches(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MedicationOrderDispenseRequestComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
                if( !DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if( !DeepComparable.IsExactly(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("MedicationOrderDosageInstructionComponent")]
        [DataContract]
        public partial class MedicationOrderDosageInstructionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MedicationOrderDosageInstructionComponent"; } }
            
            /// <summary>
            /// Dosage instructions expressed as text
            /// </summary>
            [FhirElement("text", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Dosage instructions expressed as text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if(value == null)
                      TextElement = null; 
                    else
                      TextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Text");
                }
            }
            
            /// <summary>
            /// Supplemental instructions - e.g. "with meals"
            /// </summary>
            [FhirElement("additionalInstructions", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept AdditionalInstructions
            {
                get { return _AdditionalInstructions; }
                set { _AdditionalInstructions = value; OnPropertyChanged("AdditionalInstructions"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _AdditionalInstructions;
            
            /// <summary>
            /// When medication should be administered
            /// </summary>
            [FhirElement("timing", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Timing Timing
            {
                get { return _Timing; }
                set { _Timing = value; OnPropertyChanged("Timing"); }
            }
            
            private Hl7.Fhir.Model.Timing _Timing;
            
            /// <summary>
            /// Take "as needed" (for x)
            /// </summary>
            [FhirElement("asNeeded", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element AsNeeded
            {
                get { return _AsNeeded; }
                set { _AsNeeded = value; OnPropertyChanged("AsNeeded"); }
            }
            
            private Hl7.Fhir.Model.Element _AsNeeded;
            
            /// <summary>
            /// Body site to administer to
            /// </summary>
            [FhirElement("site", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Site
            {
                get { return _Site; }
                set { _Site = value; OnPropertyChanged("Site"); }
            }
            
            private Hl7.Fhir.Model.Element _Site;
            
            /// <summary>
            /// How drug should enter body
            /// </summary>
            [FhirElement("route", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Route
            {
                get { return _Route; }
                set { _Route = value; OnPropertyChanged("Route"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Route;
            
            /// <summary>
            /// Technique for administering medication
            /// </summary>
            [FhirElement("method", InSummary=true, Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Method
            {
                get { return _Method; }
                set { _Method = value; OnPropertyChanged("Method"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Method;
            
            /// <summary>
            /// Amount of medication per dose
            /// </summary>
            [FhirElement("dose", InSummary=true, Order=110, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.SimpleQuantity))]
            [DataMember]
            public Hl7.Fhir.Model.Element Dose
            {
                get { return _Dose; }
                set { _Dose = value; OnPropertyChanged("Dose"); }
            }
            
            private Hl7.Fhir.Model.Element _Dose;
            
            /// <summary>
            /// Amount of medication per unit of time
            /// </summary>
            [FhirElement("rate", InSummary=true, Order=120, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Ratio),typeof(Hl7.Fhir.Model.Range))]
            [DataMember]
            public Hl7.Fhir.Model.Element Rate
            {
                get { return _Rate; }
                set { _Rate = value; OnPropertyChanged("Rate"); }
            }
            
            private Hl7.Fhir.Model.Element _Rate;
            
            /// <summary>
            /// Upper limit on medication per unit of time
            /// </summary>
            [FhirElement("maxDosePerPeriod", InSummary=true, Order=130)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio MaxDosePerPeriod
            {
                get { return _MaxDosePerPeriod; }
                set { _MaxDosePerPeriod = value; OnPropertyChanged("MaxDosePerPeriod"); }
            }
            
            private Hl7.Fhir.Model.Ratio _MaxDosePerPeriod;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MedicationOrderDosageInstructionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
                    if(AdditionalInstructions != null) dest.AdditionalInstructions = (Hl7.Fhir.Model.CodeableConcept)AdditionalInstructions.DeepCopy();
                    if(Timing != null) dest.Timing = (Hl7.Fhir.Model.Timing)Timing.DeepCopy();
                    if(AsNeeded != null) dest.AsNeeded = (Hl7.Fhir.Model.Element)AsNeeded.DeepCopy();
                    if(Site != null) dest.Site = (Hl7.Fhir.Model.Element)Site.DeepCopy();
                    if(Route != null) dest.Route = (Hl7.Fhir.Model.CodeableConcept)Route.DeepCopy();
                    if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
                    if(Dose != null) dest.Dose = (Hl7.Fhir.Model.Element)Dose.DeepCopy();
                    if(Rate != null) dest.Rate = (Hl7.Fhir.Model.Element)Rate.DeepCopy();
                    if(MaxDosePerPeriod != null) dest.MaxDosePerPeriod = (Hl7.Fhir.Model.Ratio)MaxDosePerPeriod.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MedicationOrderDosageInstructionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MedicationOrderDosageInstructionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.Matches(AdditionalInstructions, otherT.AdditionalInstructions)) return false;
                if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if( !DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
                if( !DeepComparable.Matches(Site, otherT.Site)) return false;
                if( !DeepComparable.Matches(Route, otherT.Route)) return false;
                if( !DeepComparable.Matches(Method, otherT.Method)) return false;
                if( !DeepComparable.Matches(Dose, otherT.Dose)) return false;
                if( !DeepComparable.Matches(Rate, otherT.Rate)) return false;
                if( !DeepComparable.Matches(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MedicationOrderDosageInstructionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.IsExactly(AdditionalInstructions, otherT.AdditionalInstructions)) return false;
                if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if( !DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
                if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
                if( !DeepComparable.IsExactly(Route, otherT.Route)) return false;
                if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if( !DeepComparable.IsExactly(Dose, otherT.Dose)) return false;
                if( !DeepComparable.IsExactly(Rate, otherT.Rate)) return false;
                if( !DeepComparable.IsExactly(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("MedicationOrderSubstitutionComponent")]
        [DataContract]
        public partial class MedicationOrderSubstitutionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MedicationOrderSubstitutionComponent"; } }
            
            /// <summary>
            /// generic | formulary +
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Why should (not) substitution be made
            /// </summary>
            [FhirElement("reason", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Reason
            {
                get { return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Reason;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MedicationOrderSubstitutionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Reason != null) dest.Reason = (Hl7.Fhir.Model.CodeableConcept)Reason.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MedicationOrderSubstitutionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MedicationOrderSubstitutionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MedicationOrderSubstitutionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// When prescription was authorized
        /// </summary>
        [FhirElement("dateWritten", Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateWrittenElement
        {
            get { return _DateWrittenElement; }
            set { _DateWrittenElement = value; OnPropertyChanged("DateWrittenElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateWrittenElement;
        
        /// <summary>
        /// When prescription was authorized
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateWritten
        {
            get { return DateWrittenElement != null ? DateWrittenElement.Value : null; }
            set
            {
                if(value == null)
                  DateWrittenElement = null; 
                else
                  DateWrittenElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("DateWritten");
            }
        }
        
        /// <summary>
        /// active | on-hold | completed | entered-in-error | stopped | draft
        /// </summary>
        [FhirElement("status", Order=110)]
        [DataMember]
        public Code<Hl7.Fhir.Model.MedicationOrder.MedicationOrderStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.MedicationOrder.MedicationOrderStatus> _StatusElement;
        
        /// <summary>
        /// active | on-hold | completed | entered-in-error | stopped | draft
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.MedicationOrder.MedicationOrderStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.MedicationOrder.MedicationOrderStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// When prescription was stopped
        /// </summary>
        [FhirElement("dateEnded", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateEndedElement
        {
            get { return _DateEndedElement; }
            set { _DateEndedElement = value; OnPropertyChanged("DateEndedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateEndedElement;
        
        /// <summary>
        /// When prescription was stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateEnded
        {
            get { return DateEndedElement != null ? DateEndedElement.Value : null; }
            set
            {
                if(value == null)
                  DateEndedElement = null; 
                else
                  DateEndedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("DateEnded");
            }
        }
        
        /// <summary>
        /// Why prescription was stopped
        /// </summary>
        [FhirElement("reasonEnded", Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept ReasonEnded
        {
            get { return _ReasonEnded; }
            set { _ReasonEnded = value; OnPropertyChanged("ReasonEnded"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _ReasonEnded;
        
        /// <summary>
        /// Who prescription is for
        /// </summary>
        [FhirElement("patient", Order=140)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// Who ordered the medication(s)
        /// </summary>
        [FhirElement("prescriber", Order=150)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Prescriber
        {
            get { return _Prescriber; }
            set { _Prescriber = value; OnPropertyChanged("Prescriber"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Prescriber;
        
        /// <summary>
        /// Created during encounter/admission/stay
        /// </summary>
        [FhirElement("encounter", Order=160)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Reason or indication for writing the prescription
        /// </summary>
        [FhirElement("reason", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Reason
        {
            get { return _Reason; }
            set { _Reason = value; OnPropertyChanged("Reason"); }
        }
        
        private Hl7.Fhir.Model.Element _Reason;
        
        /// <summary>
        /// Information about the prescription
        /// </summary>
        [FhirElement("note", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NoteElement
        {
            get { return _NoteElement; }
            set { _NoteElement = value; OnPropertyChanged("NoteElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NoteElement;
        
        /// <summary>
        /// Information about the prescription
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Note
        {
            get { return NoteElement != null ? NoteElement.Value : null; }
            set
            {
                if(value == null)
                  NoteElement = null; 
                else
                  NoteElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Note");
            }
        }
        
        /// <summary>
        /// Medication to be taken
        /// </summary>
        [FhirElement("medication", Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Medication
        {
            get { return _Medication; }
            set { _Medication = value; OnPropertyChanged("Medication"); }
        }
        
        private Hl7.Fhir.Model.Element _Medication;
        
        /// <summary>
        /// How medication should be taken
        /// </summary>
        [FhirElement("dosageInstruction", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.MedicationOrder.MedicationOrderDosageInstructionComponent> DosageInstruction
        {
            get { if(_DosageInstruction==null) _DosageInstruction = new List<Hl7.Fhir.Model.MedicationOrder.MedicationOrderDosageInstructionComponent>(); return _DosageInstruction; }
            set { _DosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }
        
        private List<Hl7.Fhir.Model.MedicationOrder.MedicationOrderDosageInstructionComponent> _DosageInstruction;
        
        /// <summary>
        /// Medication supply authorization
        /// </summary>
        [FhirElement("dispenseRequest", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.MedicationOrder.MedicationOrderDispenseRequestComponent DispenseRequest
        {
            get { return _DispenseRequest; }
            set { _DispenseRequest = value; OnPropertyChanged("DispenseRequest"); }
        }
        
        private Hl7.Fhir.Model.MedicationOrder.MedicationOrderDispenseRequestComponent _DispenseRequest;
        
        /// <summary>
        /// Any restrictions on medication substitution
        /// </summary>
        [FhirElement("substitution", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.MedicationOrder.MedicationOrderSubstitutionComponent Substitution
        {
            get { return _Substitution; }
            set { _Substitution = value; OnPropertyChanged("Substitution"); }
        }
        
        private Hl7.Fhir.Model.MedicationOrder.MedicationOrderSubstitutionComponent _Substitution;
        
        /// <summary>
        /// An order/prescription that this supersedes
        /// </summary>
        [FhirElement("priorPrescription", Order=230)]
        [References("MedicationOrder")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference PriorPrescription
        {
            get { return _PriorPrescription; }
            set { _PriorPrescription = value; OnPropertyChanged("PriorPrescription"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _PriorPrescription;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationOrder;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(DateWrittenElement != null) dest.DateWrittenElement = (Hl7.Fhir.Model.FhirDateTime)DateWrittenElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.MedicationOrder.MedicationOrderStatus>)StatusElement.DeepCopy();
                if(DateEndedElement != null) dest.DateEndedElement = (Hl7.Fhir.Model.FhirDateTime)DateEndedElement.DeepCopy();
                if(ReasonEnded != null) dest.ReasonEnded = (Hl7.Fhir.Model.CodeableConcept)ReasonEnded.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Prescriber != null) dest.Prescriber = (Hl7.Fhir.Model.ResourceReference)Prescriber.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(Reason != null) dest.Reason = (Hl7.Fhir.Model.Element)Reason.DeepCopy();
                if(NoteElement != null) dest.NoteElement = (Hl7.Fhir.Model.FhirString)NoteElement.DeepCopy();
                if(Medication != null) dest.Medication = (Hl7.Fhir.Model.Element)Medication.DeepCopy();
                if(DosageInstruction != null) dest.DosageInstruction = new List<Hl7.Fhir.Model.MedicationOrder.MedicationOrderDosageInstructionComponent>(DosageInstruction.DeepCopy());
                if(DispenseRequest != null) dest.DispenseRequest = (Hl7.Fhir.Model.MedicationOrder.MedicationOrderDispenseRequestComponent)DispenseRequest.DeepCopy();
                if(Substitution != null) dest.Substitution = (Hl7.Fhir.Model.MedicationOrder.MedicationOrderSubstitutionComponent)Substitution.DeepCopy();
                if(PriorPrescription != null) dest.PriorPrescription = (Hl7.Fhir.Model.ResourceReference)PriorPrescription.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new MedicationOrder());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationOrder;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(DateEndedElement, otherT.DateEndedElement)) return false;
            if( !DeepComparable.Matches(ReasonEnded, otherT.ReasonEnded)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Prescriber, otherT.Prescriber)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if( !DeepComparable.Matches(NoteElement, otherT.NoteElement)) return false;
            if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if( !DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if( !DeepComparable.Matches(DispenseRequest, otherT.DispenseRequest)) return false;
            if( !DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
            if( !DeepComparable.Matches(PriorPrescription, otherT.PriorPrescription)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationOrder;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(DateEndedElement, otherT.DateEndedElement)) return false;
            if( !DeepComparable.IsExactly(ReasonEnded, otherT.ReasonEnded)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Prescriber, otherT.Prescriber)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if( !DeepComparable.IsExactly(NoteElement, otherT.NoteElement)) return false;
            if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if( !DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if( !DeepComparable.IsExactly(DispenseRequest, otherT.DispenseRequest)) return false;
            if( !DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
            if( !DeepComparable.IsExactly(PriorPrescription, otherT.PriorPrescription)) return false;
            
            return true;
        }
        
    }
    
}
