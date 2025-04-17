using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class PossessingLowSeverityDrug : Crime
	{
		// Token: 0x06004B14 RID: 19220 RVA: 0x0016B4C0 File Offset: 0x001696C0
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingLowSeverityDrug()
		{
			Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingLowSeverityDrug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr);
			PossessingLowSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingLowSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, 100672603);
			PossessingLowSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, 100672604);
			PossessingLowSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr, 100672605);
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x0016B540 File Offset: 0x00169740
		// (set) Token: 0x06004B16 RID: 19222 RVA: 0x0016B584 File Offset: 0x00169784
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingLowSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingLowSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x0016B5D4 File Offset: 0x001697D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164620, RefRangeEnd = 164621, XrefRangeStart = 164611, XrefRangeEnd = 164620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingLowSeverityDrug() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingLowSeverityDrug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingLowSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x0002427F File Offset: 0x0002247F
		public PossessingLowSeverityDrug(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x0016B610 File Offset: 0x00169810
		// (set) Token: 0x06004B1A RID: 19226 RVA: 0x00024288 File Offset: 0x00022488
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingLowSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingLowSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
