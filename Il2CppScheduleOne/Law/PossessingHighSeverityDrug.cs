using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C6 RID: 966
	[Serializable]
	public class PossessingHighSeverityDrug : Crime
	{
		// Token: 0x06004B22 RID: 19234 RVA: 0x0016B7B0 File Offset: 0x001699B0
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingHighSeverityDrug()
		{
			Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingHighSeverityDrug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr);
			PossessingHighSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingHighSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr, 100672609);
			PossessingHighSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr, 100672610);
			PossessingHighSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr, 100672611);
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x0016B830 File Offset: 0x00169A30
		// (set) Token: 0x06004B24 RID: 19236 RVA: 0x0016B874 File Offset: 0x00169A74
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingHighSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingHighSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0016B8C4 File Offset: 0x00169AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164640, RefRangeEnd = 164641, XrefRangeStart = 164631, XrefRangeEnd = 164640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingHighSeverityDrug() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingHighSeverityDrug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingHighSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x000242CF File Offset: 0x000224CF
		public PossessingHighSeverityDrug(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x0016B900 File Offset: 0x00169B00
		// (set) Token: 0x06004B28 RID: 19240 RVA: 0x000242D8 File Offset: 0x000224D8
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingHighSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingHighSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032B1 RID: 12977
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032B2 RID: 12978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
