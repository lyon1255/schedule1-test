using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C9 RID: 969
	[Serializable]
	public class DrugTrafficking : Crime
	{
		// Token: 0x06004B37 RID: 19255 RVA: 0x0016BC18 File Offset: 0x00169E18
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTrafficking()
		{
			Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DrugTrafficking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr);
			DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, "<CrimeName>k__BackingField");
			DrugTrafficking.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672618);
			DrugTrafficking.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672619);
			DrugTrafficking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672620);
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x0016BC98 File Offset: 0x00169E98
		// (set) Token: 0x06004B39 RID: 19257 RVA: 0x0016BCDC File Offset: 0x00169EDC
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrugTrafficking.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrugTrafficking.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x0016BD2C File Offset: 0x00169F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164673, RefRangeEnd = 164674, XrefRangeStart = 164664, XrefRangeEnd = 164673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTrafficking() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTrafficking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00024347 File Offset: 0x00022547
		public DrugTrafficking(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x0016BD68 File Offset: 0x00169F68
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x00024350 File Offset: 0x00022550
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
