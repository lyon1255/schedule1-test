using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D2 RID: 978
	[Serializable]
	public class BrandishingWeapon : Crime
	{
		// Token: 0x06004B76 RID: 19318 RVA: 0x0016C950 File Offset: 0x0016AB50
		// Note: this type is marked as 'beforefieldinit'.
		static BrandishingWeapon()
		{
			Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "BrandishingWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr);
			BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, "<CrimeName>k__BackingField");
			BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672645);
			BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672646);
			BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672647);
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06004B77 RID: 19319 RVA: 0x0016C9D0 File Offset: 0x0016ABD0
		// (set) Token: 0x06004B78 RID: 19320 RVA: 0x0016CA14 File Offset: 0x0016AC14
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x0016CA64 File Offset: 0x0016AC64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164765, RefRangeEnd = 164767, XrefRangeStart = 164756, XrefRangeEnd = 164765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrandishingWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x000244AF File Offset: 0x000226AF
		public BrandishingWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x0016CAA0 File Offset: 0x0016ACA0
		// (set) Token: 0x06004B7C RID: 19324 RVA: 0x000244B8 File Offset: 0x000226B8
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
