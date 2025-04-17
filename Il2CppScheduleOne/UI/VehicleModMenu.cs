using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000672 RID: 1650
	public class VehicleModMenu : Singleton<VehicleModMenu>
	{
		// Token: 0x06009330 RID: 37680 RVA: 0x0025E68C File Offset: 0x0025C88C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleModMenu()
		{
			Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VehicleModMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr);
			VehicleModMenu.NativeFieldInfoPtr_repaintCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "repaintCost");
			VehicleModMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			VehicleModMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "canvas");
			VehicleModMenu.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "buttonContainer");
			VehicleModMenu.NativeFieldInfoPtr_tempIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "tempIndicator");
			VehicleModMenu.NativeFieldInfoPtr_permIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "permIndicator");
			VehicleModMenu.NativeFieldInfoPtr_confirmButton_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "confirmButton_Online");
			VehicleModMenu.NativeFieldInfoPtr_confirmText_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "confirmText_Online");
			VehicleModMenu.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "CameraPosition");
			VehicleModMenu.NativeFieldInfoPtr_VehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "VehiclePosition");
			VehicleModMenu.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "buttonPrefab");
			VehicleModMenu.NativeFieldInfoPtr_onPaintPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "onPaintPurchased");
			VehicleModMenu.NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "currentVehicle");
			VehicleModMenu.NativeFieldInfoPtr_colorButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "colorButtons");
			VehicleModMenu.NativeFieldInfoPtr_colorToButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "colorToButton");
			VehicleModMenu.NativeFieldInfoPtr_selectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "selectedColor");
			VehicleModMenu.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "openCloseRoutine");
			VehicleModMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681542);
			VehicleModMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681543);
			VehicleModMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681544);
			VehicleModMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681545);
			VehicleModMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681546);
			VehicleModMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681547);
			VehicleModMenu.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681548);
			VehicleModMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681549);
			VehicleModMenu.NativeMethodInfoPtr_ColorClicked_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681550);
			VehicleModMenu.NativeMethodInfoPtr_UpdateConfirmButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681551);
			VehicleModMenu.NativeMethodInfoPtr_RefreshSelectionIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681552);
			VehicleModMenu.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681553);
			VehicleModMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681554);
			VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681556);
			VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681557);
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x0025E93C File Offset: 0x0025CB3C
		// (set) Token: 0x06009332 RID: 37682 RVA: 0x0025E978 File Offset: 0x0025CB78
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x0025E9B8 File Offset: 0x0025CBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265066, XrefRangeEnd = 265079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009334 RID: 37684 RVA: 0x0025E9F4 File Offset: 0x0025CBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265079, XrefRangeEnd = 265151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x0025EA30 File Offset: 0x0025CC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265151, XrefRangeEnd = 265152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x0025EA74 File Offset: 0x0025CC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265152, XrefRangeEnd = 265153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x0025EAB0 File Offset: 0x0025CCB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265173, RefRangeEnd = 265175, XrefRangeStart = 265153, XrefRangeEnd = 265173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x0025EAF4 File Offset: 0x0025CCF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265188, RefRangeEnd = 265192, XrefRangeStart = 265175, XrefRangeEnd = 265188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x0025EB28 File Offset: 0x0025CD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265192, XrefRangeEnd = 265195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorClicked(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_ColorClicked_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x0025EB68 File Offset: 0x0025CD68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265206, RefRangeEnd = 265210, XrefRangeStart = 265195, XrefRangeEnd = 265206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConfirmButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_UpdateConfirmButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x0025EB9C File Offset: 0x0025CD9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265219, RefRangeEnd = 265223, XrefRangeStart = 265210, XrefRangeEnd = 265219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSelectionIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_RefreshSelectionIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x0025EBD0 File Offset: 0x0025CDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265223, XrefRangeEnd = 265244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x0025EC04 File Offset: 0x0025CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265244, XrefRangeEnd = 265261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleModMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x0025EC40 File Offset: 0x0025CE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265261, XrefRangeEnd = 265266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x0025EC80 File Offset: 0x0025CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265266, XrefRangeEnd = 265271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x000474B5 File Offset: 0x000456B5
		public VehicleModMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x0025ECC0 File Offset: 0x0025CEC0
		// (set) Token: 0x06009342 RID: 37698 RVA: 0x000474BE File Offset: 0x000456BE
		public unsafe static float repaintCost
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleModMenu.NativeFieldInfoPtr_repaintCost, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleModMenu.NativeFieldInfoPtr_repaintCost, (void*)(&value));
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x0025ECDC File Offset: 0x0025CEDC
		// (set) Token: 0x06009344 RID: 37700 RVA: 0x000474CC File Offset: 0x000456CC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x06009345 RID: 37701 RVA: 0x0025ED04 File Offset: 0x0025CF04
		// (set) Token: 0x06009346 RID: 37702 RVA: 0x000474E7 File Offset: 0x000456E7
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06009347 RID: 37703 RVA: 0x0025ED34 File Offset: 0x0025CF34
		// (set) Token: 0x06009348 RID: 37704 RVA: 0x00047506 File Offset: 0x00045706
		public unsafe RectTransform buttonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06009349 RID: 37705 RVA: 0x0025ED64 File Offset: 0x0025CF64
		// (set) Token: 0x0600934A RID: 37706 RVA: 0x00047525 File Offset: 0x00045725
		public unsafe RectTransform tempIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_tempIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_tempIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x0025ED94 File Offset: 0x0025CF94
		// (set) Token: 0x0600934C RID: 37708 RVA: 0x00047544 File Offset: 0x00045744
		public unsafe RectTransform permIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_permIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_permIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x0025EDC4 File Offset: 0x0025CFC4
		// (set) Token: 0x0600934E RID: 37710 RVA: 0x00047563 File Offset: 0x00045763
		public unsafe Button confirmButton_Online
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmButton_Online);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmButton_Online), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600934F RID: 37711 RVA: 0x0025EDF4 File Offset: 0x0025CFF4
		// (set) Token: 0x06009350 RID: 37712 RVA: 0x00047582 File Offset: 0x00045782
		public unsafe TextMeshProUGUI confirmText_Online
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmText_Online);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmText_Online), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x0025EE24 File Offset: 0x0025D024
		// (set) Token: 0x06009352 RID: 37714 RVA: 0x000475A1 File Offset: 0x000457A1
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x06009353 RID: 37715 RVA: 0x0025EE54 File Offset: 0x0025D054
		// (set) Token: 0x06009354 RID: 37716 RVA: 0x000475C0 File Offset: 0x000457C0
		public unsafe Transform VehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_VehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_VehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x0025EE84 File Offset: 0x0025D084
		// (set) Token: 0x06009356 RID: 37718 RVA: 0x000475DF File Offset: 0x000457DF
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x06009357 RID: 37719 RVA: 0x0025EEB4 File Offset: 0x0025D0B4
		// (set) Token: 0x06009358 RID: 37720 RVA: 0x000475FE File Offset: 0x000457FE
		public unsafe UnityEvent onPaintPurchased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_onPaintPurchased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_onPaintPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06009359 RID: 37721 RVA: 0x0025EEE4 File Offset: 0x0025D0E4
		// (set) Token: 0x0600935A RID: 37722 RVA: 0x0004761D File Offset: 0x0004581D
		public unsafe LandVehicle currentVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_currentVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_currentVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600935B RID: 37723 RVA: 0x0025EF14 File Offset: 0x0025D114
		// (set) Token: 0x0600935C RID: 37724 RVA: 0x0004763C File Offset: 0x0004583C
		public unsafe List<RectTransform> colorButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0600935D RID: 37725 RVA: 0x0025EF44 File Offset: 0x0025D144
		// (set) Token: 0x0600935E RID: 37726 RVA: 0x0004765B File Offset: 0x0004585B
		public unsafe Dictionary<EVehicleColor, RectTransform> colorToButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorToButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EVehicleColor, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorToButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600935F RID: 37727 RVA: 0x0025EF74 File Offset: 0x0025D174
		// (set) Token: 0x06009360 RID: 37728 RVA: 0x0004767A File Offset: 0x0004587A
		public unsafe EVehicleColor selectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_selectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_selectedColor)) = value;
			}
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x0025EF9C File Offset: 0x0025D19C
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x00047695 File Offset: 0x00045895
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_openCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400635F RID: 25439
		private static readonly IntPtr NativeFieldInfoPtr_repaintCost;

		// Token: 0x04006360 RID: 25440
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006361 RID: 25441
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006362 RID: 25442
		private static readonly IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x04006363 RID: 25443
		private static readonly IntPtr NativeFieldInfoPtr_tempIndicator;

		// Token: 0x04006364 RID: 25444
		private static readonly IntPtr NativeFieldInfoPtr_permIndicator;

		// Token: 0x04006365 RID: 25445
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton_Online;

		// Token: 0x04006366 RID: 25446
		private static readonly IntPtr NativeFieldInfoPtr_confirmText_Online;

		// Token: 0x04006367 RID: 25447
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04006368 RID: 25448
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePosition;

		// Token: 0x04006369 RID: 25449
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x0400636A RID: 25450
		private static readonly IntPtr NativeFieldInfoPtr_onPaintPurchased;

		// Token: 0x0400636B RID: 25451
		private static readonly IntPtr NativeFieldInfoPtr_currentVehicle;

		// Token: 0x0400636C RID: 25452
		private static readonly IntPtr NativeFieldInfoPtr_colorButtons;

		// Token: 0x0400636D RID: 25453
		private static readonly IntPtr NativeFieldInfoPtr_colorToButton;

		// Token: 0x0400636E RID: 25454
		private static readonly IntPtr NativeFieldInfoPtr_selectedColor;

		// Token: 0x0400636F RID: 25455
		private static readonly IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x04006370 RID: 25456
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006371 RID: 25457
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006372 RID: 25458
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006373 RID: 25459
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006374 RID: 25460
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006375 RID: 25461
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006376 RID: 25462
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0;

		// Token: 0x04006377 RID: 25463
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006378 RID: 25464
		private static readonly IntPtr NativeMethodInfoPtr_ColorClicked_Public_Void_EVehicleColor_0;

		// Token: 0x04006379 RID: 25465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfirmButton_Private_Void_0;

		// Token: 0x0400637A RID: 25466
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSelectionIndicator_Private_Void_0;

		// Token: 0x0400637B RID: 25467
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0;

		// Token: 0x0400637C RID: 25468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400637D RID: 25469
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400637E RID: 25470
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B52 RID: 2898
		[ObfuscatedName("ScheduleOne.UI.VehicleModMenu+<<Close>g__Close|25_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9B2 RID: 55730 RVA: 0x0033A208 File Offset: 0x00338408
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<<Close>g__Close|25_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681558);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681559);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681560);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681561);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681562);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681563);
			}

			// Token: 0x0600D9B3 RID: 55731 RVA: 0x0033A2E8 File Offset: 0x003384E8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9B4 RID: 55732 RVA: 0x0033A330 File Offset: 0x00338530
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9B5 RID: 55733 RVA: 0x0033A364 File Offset: 0x00338564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264997, XrefRangeEnd = 265012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700438C RID: 17292
			// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x0033A3A0 File Offset: 0x003385A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9B7 RID: 55735 RVA: 0x0033A3E0 File Offset: 0x003385E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265012, XrefRangeEnd = 265017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700438D RID: 17293
			// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x0033A414 File Offset: 0x00338614
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9B9 RID: 55737 RVA: 0x0006A06D File Offset: 0x0006826D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004389 RID: 17289
			// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x0033A454 File Offset: 0x00338654
			// (set) Token: 0x0600D9BB RID: 55739 RVA: 0x0006A076 File Offset: 0x00068276
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700438A RID: 17290
			// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x0033A47C File Offset: 0x0033867C
			// (set) Token: 0x0600D9BD RID: 55741 RVA: 0x0006A091 File Offset: 0x00068291
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438B RID: 17291
			// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x0033A4AC File Offset: 0x003386AC
			// (set) Token: 0x0600D9BF RID: 55743 RVA: 0x0006A0B0 File Offset: 0x000682B0
			public unsafe VehicleModMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleModMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009233 RID: 37427
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009234 RID: 37428
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009235 RID: 37429
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009236 RID: 37430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009237 RID: 37431
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009238 RID: 37432
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009239 RID: 37433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400923A RID: 37434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400923B RID: 37435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B53 RID: 2899
		[ObfuscatedName("ScheduleOne.UI.VehicleModMenu+<<Open>g__Close|24_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D9C0 RID: 55744 RVA: 0x0033A4DC File Offset: 0x003386DC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<<Open>g__Close|24_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681564);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681565);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681566);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681567);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681568);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681569);
			}

			// Token: 0x0600D9C1 RID: 55745 RVA: 0x0033A5BC File Offset: 0x003387BC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C2 RID: 55746 RVA: 0x0033A604 File Offset: 0x00338804
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C3 RID: 55747 RVA: 0x0033A638 File Offset: 0x00338838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265017, XrefRangeEnd = 265058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004391 RID: 17297
			// (get) Token: 0x0600D9C4 RID: 55748 RVA: 0x0033A674 File Offset: 0x00338874
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9C5 RID: 55749 RVA: 0x0033A6B4 File Offset: 0x003388B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265058, XrefRangeEnd = 265063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004392 RID: 17298
			// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x0033A6E8 File Offset: 0x003388E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9C7 RID: 55751 RVA: 0x0006A0CF File Offset: 0x000682CF
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700438E RID: 17294
			// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x0033A728 File Offset: 0x00338928
			// (set) Token: 0x0600D9C9 RID: 55753 RVA: 0x0006A0D8 File Offset: 0x000682D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700438F RID: 17295
			// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x0033A750 File Offset: 0x00338950
			// (set) Token: 0x0600D9CB RID: 55755 RVA: 0x0006A0F3 File Offset: 0x000682F3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004390 RID: 17296
			// (get) Token: 0x0600D9CC RID: 55756 RVA: 0x0033A780 File Offset: 0x00338980
			// (set) Token: 0x0600D9CD RID: 55757 RVA: 0x0006A112 File Offset: 0x00068312
			public unsafe VehicleModMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleModMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400923C RID: 37436
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400923D RID: 37437
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400923E RID: 37438
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400923F RID: 37439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009240 RID: 37440
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009241 RID: 37441
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009242 RID: 37442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009243 RID: 37443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009244 RID: 37444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B54 RID: 2900
		[ObfuscatedName("ScheduleOne.UI.VehicleModMenu+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9CE RID: 55758 RVA: 0x0033A7B0 File Offset: 0x003389B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr);
				VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, "c");
				VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, 100681570);
				VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, 100681571);
			}

			// Token: 0x0600D9CF RID: 55759 RVA: 0x0033A82C File Offset: 0x00338A2C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9D0 RID: 55760 RVA: 0x0033A868 File Offset: 0x00338A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265063, XrefRangeEnd = 265066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9D1 RID: 55761 RVA: 0x0006A131 File Offset: 0x00068331
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004393 RID: 17299
			// (get) Token: 0x0600D9D2 RID: 55762 RVA: 0x0033A89C File Offset: 0x00338A9C
			// (set) Token: 0x0600D9D3 RID: 55763 RVA: 0x0006A13A File Offset: 0x0006833A
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x17004394 RID: 17300
			// (get) Token: 0x0600D9D4 RID: 55764 RVA: 0x0033A8C4 File Offset: 0x00338AC4
			// (set) Token: 0x0600D9D5 RID: 55765 RVA: 0x0006A155 File Offset: 0x00068355
			public unsafe VehicleModMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleModMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009245 RID: 37445
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04009246 RID: 37446
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009247 RID: 37447
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009248 RID: 37448
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
