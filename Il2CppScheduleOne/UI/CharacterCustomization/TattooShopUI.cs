using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006FA RID: 1786
	public class TattooShopUI : CharacterCustomizationUI
	{
		// Token: 0x0600A062 RID: 41058 RVA: 0x00286274 File Offset: 0x00284474
		// Note: this type is marked as 'beforefieldinit'.
		static TattooShopUI()
		{
			Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "TattooShopUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr);
			TattooShopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100682917);
			TattooShopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100682918);
			TattooShopUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100682919);
			TattooShopUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100682920);
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x002862F4 File Offset: 0x002844F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282214, XrefRangeEnd = 282234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TattooShopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x0028634C File Offset: 0x0028454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282234, XrefRangeEnd = 282246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TattooShopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x0028639C File Offset: 0x0028459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282246, XrefRangeEnd = 282260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TattooShopUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A066 RID: 41062 RVA: 0x002863EC File Offset: 0x002845EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TattooShopUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TattooShopUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A067 RID: 41063 RVA: 0x0004EE37 File Offset: 0x0004D037
		public TattooShopUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006B89 RID: 27529
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04006B8A RID: 27530
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B8B RID: 27531
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B8C RID: 27532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
