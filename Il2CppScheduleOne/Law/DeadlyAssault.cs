using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CF RID: 975
	[Serializable]
	public class DeadlyAssault : Crime
	{
		// Token: 0x06004B61 RID: 19297 RVA: 0x0016C4E8 File Offset: 0x0016A6E8
		// Note: this type is marked as 'beforefieldinit'.
		static DeadlyAssault()
		{
			Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DeadlyAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr);
			DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, "<CrimeName>k__BackingField");
			DeadlyAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100672636);
			DeadlyAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100672637);
			DeadlyAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100672638);
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x0016C568 File Offset: 0x0016A768
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x0016C5AC File Offset: 0x0016A7AC
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadlyAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadlyAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x0016C5FC File Offset: 0x0016A7FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164735, RefRangeEnd = 164736, XrefRangeStart = 164726, XrefRangeEnd = 164735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadlyAssault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadlyAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00024437 File Offset: 0x00022637
		public DeadlyAssault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x0016C638 File Offset: 0x0016A838
		// (set) Token: 0x06004B67 RID: 19303 RVA: 0x00024440 File Offset: 0x00022640
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
