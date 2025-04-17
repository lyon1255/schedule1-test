using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D3 RID: 979
	[Serializable]
	public class DischargeFirearm : Crime
	{
		// Token: 0x06004B7D RID: 19325 RVA: 0x0016CAC8 File Offset: 0x0016ACC8
		// Note: this type is marked as 'beforefieldinit'.
		static DischargeFirearm()
		{
			Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DischargeFirearm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr);
			DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, "<CrimeName>k__BackingField");
			DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672648);
			DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672649);
			DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672650);
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0016CB48 File Offset: 0x0016AD48
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x0016CB8C File Offset: 0x0016AD8C
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x0016CBDC File Offset: 0x0016ADDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164776, RefRangeEnd = 164778, XrefRangeStart = 164767, XrefRangeEnd = 164776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DischargeFirearm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x000244D7 File Offset: 0x000226D7
		public DischargeFirearm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x0016CC18 File Offset: 0x0016AE18
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x000244E0 File Offset: 0x000226E0
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
