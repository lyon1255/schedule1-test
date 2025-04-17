using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C5 RID: 965
	[Serializable]
	public class PossessingModerateSeverityDrug : Crime
	{
		// Token: 0x06004B1B RID: 19227 RVA: 0x0016B638 File Offset: 0x00169838
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingModerateSeverityDrug()
		{
			Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingModerateSeverityDrug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr);
			PossessingModerateSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingModerateSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, 100672606);
			PossessingModerateSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, 100672607);
			PossessingModerateSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr, 100672608);
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x0016B6B8 File Offset: 0x001698B8
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x0016B6FC File Offset: 0x001698FC
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingModerateSeverityDrug.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingModerateSeverityDrug.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0016B74C File Offset: 0x0016994C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164630, RefRangeEnd = 164631, XrefRangeStart = 164621, XrefRangeEnd = 164630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingModerateSeverityDrug() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingModerateSeverityDrug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingModerateSeverityDrug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x000242A7 File Offset: 0x000224A7
		public PossessingModerateSeverityDrug(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x0016B788 File Offset: 0x00169988
		// (set) Token: 0x06004B21 RID: 19233 RVA: 0x000242B0 File Offset: 0x000224B0
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingModerateSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingModerateSeverityDrug.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
