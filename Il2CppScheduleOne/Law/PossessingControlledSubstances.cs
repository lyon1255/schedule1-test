using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class PossessingControlledSubstances : Crime
	{
		// Token: 0x06004B0D RID: 19213 RVA: 0x0016B348 File Offset: 0x00169548
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingControlledSubstances()
		{
			Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingControlledSubstances");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr);
			PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672600);
			PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672601);
			PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672602);
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0016B3C8 File Offset: 0x001695C8
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x0016B40C File Offset: 0x0016960C
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x0016B45C File Offset: 0x0016965C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164610, RefRangeEnd = 164611, XrefRangeStart = 164601, XrefRangeEnd = 164610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingControlledSubstances() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00024257 File Offset: 0x00022457
		public PossessingControlledSubstances(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x0016B498 File Offset: 0x00169698
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x00024260 File Offset: 0x00022460
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032A4 RID: 12964
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
