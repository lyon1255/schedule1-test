using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000693 RID: 1683
	public class SettingsSlider : MonoBehaviour
	{
		// Token: 0x06009605 RID: 38405 RVA: 0x00267138 File Offset: 0x00265338
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSlider()
		{
			Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr);
			SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "VALUE_DISPLAY_TIME");
			SettingsSlider.NativeFieldInfoPtr_DisplayValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "DisplayValue");
			SettingsSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "slider");
			SettingsSlider.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "valueLabel");
			SettingsSlider.NativeFieldInfoPtr_timeOnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "timeOnValueChange");
			SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681847);
			SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681848);
			SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681849);
			SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681850);
			SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681851);
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x00267230 File Offset: 0x00265430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269141, XrefRangeEnd = 269160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x0026726C File Offset: 0x0026546C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269160, XrefRangeEnd = 269162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x002672A8 File Offset: 0x002654A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 269164, RefRangeEnd = 269170, XrefRangeStart = 269162, XrefRangeEnd = 269164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x002672F4 File Offset: 0x002654F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269170, XrefRangeEnd = 269171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x00267344 File Offset: 0x00265544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x00048D61 File Offset: 0x00046F61
		public SettingsSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600960C RID: 38412 RVA: 0x00267380 File Offset: 0x00265580
		// (set) Token: 0x0600960D RID: 38413 RVA: 0x00048D6A File Offset: 0x00046F6A
		public unsafe static float VALUE_DISPLAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600960E RID: 38414 RVA: 0x0026739C File Offset: 0x0026559C
		// (set) Token: 0x0600960F RID: 38415 RVA: 0x00048D78 File Offset: 0x00046F78
		public unsafe bool DisplayValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue)) = value;
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x06009610 RID: 38416 RVA: 0x002673C4 File Offset: 0x002655C4
		// (set) Token: 0x06009611 RID: 38417 RVA: 0x00048D93 File Offset: 0x00046F93
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x06009612 RID: 38418 RVA: 0x002673F4 File Offset: 0x002655F4
		// (set) Token: 0x06009613 RID: 38419 RVA: 0x00048DB2 File Offset: 0x00046FB2
		public unsafe TextMeshProUGUI valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x06009614 RID: 38420 RVA: 0x00267424 File Offset: 0x00265624
		// (set) Token: 0x06009615 RID: 38421 RVA: 0x00048DD1 File Offset: 0x00046FD1
		public unsafe float timeOnValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange)) = value;
			}
		}

		// Token: 0x04006525 RID: 25893
		private static readonly IntPtr NativeFieldInfoPtr_VALUE_DISPLAY_TIME;

		// Token: 0x04006526 RID: 25894
		private static readonly IntPtr NativeFieldInfoPtr_DisplayValue;

		// Token: 0x04006527 RID: 25895
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04006528 RID: 25896
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04006529 RID: 25897
		private static readonly IntPtr NativeFieldInfoPtr_timeOnValueChange;

		// Token: 0x0400652A RID: 25898
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400652B RID: 25899
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400652C RID: 25900
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0;

		// Token: 0x0400652D RID: 25901
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0;

		// Token: 0x0400652E RID: 25902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
