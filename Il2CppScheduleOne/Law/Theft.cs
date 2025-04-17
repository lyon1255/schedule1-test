using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D1 RID: 977
	[Serializable]
	public class Theft : Crime
	{
		// Token: 0x06004B6F RID: 19311 RVA: 0x0016C7D8 File Offset: 0x0016A9D8
		// Note: this type is marked as 'beforefieldinit'.
		static Theft()
		{
			Il2CppClassPointerStore<Theft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Theft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Theft>.NativeClassPtr);
			Theft.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theft>.NativeClassPtr, "<CrimeName>k__BackingField");
			Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672642);
			Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672643);
			Theft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672644);
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x0016C858 File Offset: 0x0016AA58
		// (set) Token: 0x06004B71 RID: 19313 RVA: 0x0016C89C File Offset: 0x0016AA9C
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x0016C8EC File Offset: 0x0016AAEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164755, RefRangeEnd = 164756, XrefRangeStart = 164746, XrefRangeEnd = 164755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Theft() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Theft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Theft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00024487 File Offset: 0x00022687
		public Theft(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x0016C928 File Offset: 0x0016AB28
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x00024490 File Offset: 0x00022690
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
