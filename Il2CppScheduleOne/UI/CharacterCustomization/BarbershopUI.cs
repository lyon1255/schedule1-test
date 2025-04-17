using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F6 RID: 1782
	public class BarbershopUI : CharacterCustomizationUI
	{
		// Token: 0x06009FC7 RID: 40903 RVA: 0x00284500 File Offset: 0x00282700
		// Note: this type is marked as 'beforefieldinit'.
		static BarbershopUI()
		{
			Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "BarbershopUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr);
			BarbershopUI.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ColorPicker");
			BarbershopUI.NativeFieldInfoPtr_ApplyColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ApplyColorButton");
			BarbershopUI.NativeFieldInfoPtr_appliedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "appliedColor");
			BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682848);
			BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682849);
			BarbershopUI.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682850);
			BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682851);
			BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682852);
			BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682853);
			BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682854);
			BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682855);
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x0028460C File Offset: 0x0028280C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281679, XrefRangeEnd = 281681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x00284664 File Offset: 0x00282864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281681, XrefRangeEnd = 281687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x002846B4 File Offset: 0x002828B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281687, XrefRangeEnd = 281695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x002846F0 File Offset: 0x002828F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281695, XrefRangeEnd = 281699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x0028472C File Offset: 0x0028292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281699, XrefRangeEnd = 281703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorFieldChanged(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x0028476C File Offset: 0x0028296C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281703, XrefRangeEnd = 281707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x002847A0 File Offset: 0x002829A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281707, XrefRangeEnd = 281712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x002847D4 File Offset: 0x002829D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281712, XrefRangeEnd = 281717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BarbershopUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x0004E867 File Offset: 0x0004CA67
		public BarbershopUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06009FD1 RID: 40913 RVA: 0x00284810 File Offset: 0x00282A10
		// (set) Token: 0x06009FD2 RID: 40914 RVA: 0x0004E870 File Offset: 0x0004CA70
		public unsafe ColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x00284840 File Offset: 0x00282A40
		// (set) Token: 0x06009FD4 RID: 40916 RVA: 0x0004E88F File Offset: 0x0004CA8F
		public unsafe Button ApplyColorButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x00284870 File Offset: 0x00282A70
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x0004E8AE File Offset: 0x0004CAAE
		public unsafe Color appliedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor)) = value;
			}
		}

		// Token: 0x04006B26 RID: 27430
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x04006B27 RID: 27431
		private static readonly IntPtr NativeFieldInfoPtr_ApplyColorButton;

		// Token: 0x04006B28 RID: 27432
		private static readonly IntPtr NativeFieldInfoPtr_appliedColor;

		// Token: 0x04006B29 RID: 27433
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04006B2A RID: 27434
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B2B RID: 27435
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006B2C RID: 27436
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006B2D RID: 27437
		private static readonly IntPtr NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0;

		// Token: 0x04006B2E RID: 27438
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorChange_Public_Void_0;

		// Token: 0x04006B2F RID: 27439
		private static readonly IntPtr NativeMethodInfoPtr_RevertColorChange_Public_Void_0;

		// Token: 0x04006B30 RID: 27440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
