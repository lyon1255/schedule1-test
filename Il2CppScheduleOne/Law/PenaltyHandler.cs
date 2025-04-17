using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DA RID: 986
	public static class PenaltyHandler : Object
	{
		// Token: 0x06004C45 RID: 19525 RVA: 0x0016F338 File Offset: 0x0016D538
		// Note: this type is marked as 'beforefieldinit'.
		static PenaltyHandler()
		{
			Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PenaltyHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr);
			PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "CONTROLLED_SUBSTANCE_FINE");
			PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "LOW_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "MED_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "HIGH_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "FAILURE_TO_COMPLY_FINE");
			PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "EVADING_ARREST_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VIOLATING_CURFEW_TIME");
			PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ATTEMPT_TO_SELL_FINE");
			PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DEADLY_ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VANDALISM_FINE");
			PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "THEFT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "BRANDISHING_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DISCHARGE_FIREARM_FINE");
			PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, 100672734);
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x0016F494 File Offset: 0x0016D694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165547, RefRangeEnd = 165548, XrefRangeStart = 165436, XrefRangeEnd = 165547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crimes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x00024AA7 File Offset: 0x00022CA7
		public PenaltyHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x0016F4D8 File Offset: 0x0016D6D8
		// (set) Token: 0x06004C49 RID: 19529 RVA: 0x00024AB0 File Offset: 0x00022CB0
		public unsafe static float CONTROLLED_SUBSTANCE_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x0016F4F4 File Offset: 0x0016D6F4
		// (set) Token: 0x06004C4B RID: 19531 RVA: 0x00024ABE File Offset: 0x00022CBE
		public unsafe static float LOW_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x0016F510 File Offset: 0x0016D710
		// (set) Token: 0x06004C4D RID: 19533 RVA: 0x00024ACC File Offset: 0x00022CCC
		public unsafe static float MED_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x0016F52C File Offset: 0x0016D72C
		// (set) Token: 0x06004C4F RID: 19535 RVA: 0x00024ADA File Offset: 0x00022CDA
		public unsafe static float HIGH_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x0016F548 File Offset: 0x0016D748
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x00024AE8 File Offset: 0x00022CE8
		public unsafe static float FAILURE_TO_COMPLY_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x0016F564 File Offset: 0x0016D764
		// (set) Token: 0x06004C53 RID: 19539 RVA: 0x00024AF6 File Offset: 0x00022CF6
		public unsafe static float EVADING_ARREST_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x0016F580 File Offset: 0x0016D780
		// (set) Token: 0x06004C55 RID: 19541 RVA: 0x00024B04 File Offset: 0x00022D04
		public unsafe static float VIOLATING_CURFEW_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06004C56 RID: 19542 RVA: 0x0016F59C File Offset: 0x0016D79C
		// (set) Token: 0x06004C57 RID: 19543 RVA: 0x00024B12 File Offset: 0x00022D12
		public unsafe static float ATTEMPT_TO_SELL_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x0016F5B8 File Offset: 0x0016D7B8
		// (set) Token: 0x06004C59 RID: 19545 RVA: 0x00024B20 File Offset: 0x00022D20
		public unsafe static float ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x0016F5D4 File Offset: 0x0016D7D4
		// (set) Token: 0x06004C5B RID: 19547 RVA: 0x00024B2E File Offset: 0x00022D2E
		public unsafe static float DEADLY_ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x0016F5F0 File Offset: 0x0016D7F0
		// (set) Token: 0x06004C5D RID: 19549 RVA: 0x00024B3C File Offset: 0x00022D3C
		public unsafe static float VANDALISM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06004C5E RID: 19550 RVA: 0x0016F60C File Offset: 0x0016D80C
		// (set) Token: 0x06004C5F RID: 19551 RVA: 0x00024B4A File Offset: 0x00022D4A
		public unsafe static float THEFT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x0016F628 File Offset: 0x0016D828
		// (set) Token: 0x06004C61 RID: 19553 RVA: 0x00024B58 File Offset: 0x00022D58
		public unsafe static float BRANDISHING_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x0016F644 File Offset: 0x0016D844
		// (set) Token: 0x06004C63 RID: 19555 RVA: 0x00024B66 File Offset: 0x00022D66
		public unsafe static float DISCHARGE_FIREARM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&value));
			}
		}

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE;

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE;

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE;

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeFieldInfoPtr_EVADING_ARREST_FINE;

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeFieldInfoPtr_VIOLATING_CURFEW_TIME;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_FINE;

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeFieldInfoPtr_DEADLY_ASSAULT_FINE;

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeFieldInfoPtr_VANDALISM_FINE;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeFieldInfoPtr_THEFT_FINE;

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeFieldInfoPtr_BRANDISHING_FINE;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0;
	}
}
