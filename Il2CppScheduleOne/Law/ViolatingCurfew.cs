using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CC RID: 972
	[Serializable]
	public class ViolatingCurfew : Crime
	{
		// Token: 0x06004B4C RID: 19276 RVA: 0x0016C080 File Offset: 0x0016A280
		// Note: this type is marked as 'beforefieldinit'.
		static ViolatingCurfew()
		{
			Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "ViolatingCurfew");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr);
			ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, "<CrimeName>k__BackingField");
			ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672627);
			ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672628);
			ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672629);
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x0016C100 File Offset: 0x0016A300
		// (set) Token: 0x06004B4E RID: 19278 RVA: 0x0016C144 File Offset: 0x0016A344
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x0016C194 File Offset: 0x0016A394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164703, RefRangeEnd = 164704, XrefRangeStart = 164694, XrefRangeEnd = 164703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViolatingCurfew() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x000243BF File Offset: 0x000225BF
		public ViolatingCurfew(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x0016C1D0 File Offset: 0x0016A3D0
		// (set) Token: 0x06004B52 RID: 19282 RVA: 0x000243C8 File Offset: 0x000225C8
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
