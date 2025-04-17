using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C8 RID: 968
	[Serializable]
	public class VehicularAssault : Crime
	{
		// Token: 0x06004B30 RID: 19248 RVA: 0x0016BAA0 File Offset: 0x00169CA0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicularAssault()
		{
			Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehicularAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr);
			VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, "<CrimeName>k__BackingField");
			VehicularAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100672615);
			VehicularAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100672616);
			VehicularAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100672617);
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x0016BB20 File Offset: 0x00169D20
		// (set) Token: 0x06004B32 RID: 19250 RVA: 0x0016BB64 File Offset: 0x00169D64
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicularAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicularAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x0016BBB4 File Offset: 0x00169DB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164660, RefRangeEnd = 164664, XrefRangeStart = 164651, XrefRangeEnd = 164660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicularAssault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicularAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0002431F File Offset: 0x0002251F
		public VehicularAssault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x0016BBF0 File Offset: 0x00169DF0
		// (set) Token: 0x06004B36 RID: 19254 RVA: 0x00024328 File Offset: 0x00022528
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
