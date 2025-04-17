using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000784 RID: 1924
	public class POI : MonoBehaviour
	{
		// Token: 0x0600B60A RID: 46602 RVA: 0x002D3904 File Offset: 0x002D1B04
		// Note: this type is marked as 'beforefieldinit'.
		static POI()
		{
			Il2CppClassPointerStore<POI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "POI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI>.NativeClassPtr);
			POI.NativeFieldInfoPtr__UISetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UISetup>k__BackingField");
			POI.NativeFieldInfoPtr_MainTextVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "MainTextVisibility");
			POI.NativeFieldInfoPtr_DefaultMainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "DefaultMainText");
			POI.NativeFieldInfoPtr_AutoUpdatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "AutoUpdatePosition");
			POI.NativeFieldInfoPtr_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "Rotate");
			POI.NativeFieldInfoPtr__MainText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<MainText>k__BackingField");
			POI.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "UIPrefab");
			POI.NativeFieldInfoPtr__UI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UI>k__BackingField");
			POI.NativeFieldInfoPtr__IconContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<IconContainer>k__BackingField");
			POI.NativeFieldInfoPtr_mainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainLabel");
			POI.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "button");
			POI.NativeFieldInfoPtr_eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "eventTrigger");
			POI.NativeFieldInfoPtr_mainTextSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainTextSet");
			POI.NativeFieldInfoPtr_onUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "onUICreated");
			POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685677);
			POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685678);
			POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685679);
			POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685680);
			POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685681);
			POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685682);
			POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685683);
			POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685684);
			POI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685685);
			POI.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685686);
			POI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685687);
			POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685688);
			POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685689);
			POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685690);
			POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685691);
			POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685692);
			POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685693);
			POI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685694);
			POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685695);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685696);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685697);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685698);
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600B60B RID: 46603 RVA: 0x002D3C04 File Offset: 0x002D1E04
		// (set) Token: 0x0600B60C RID: 46604 RVA: 0x002D3C40 File Offset: 0x002D1E40
		public unsafe bool UISetup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600B60D RID: 46605 RVA: 0x002D3C80 File Offset: 0x002D1E80
		// (set) Token: 0x0600B60E RID: 46606 RVA: 0x002D3CB8 File Offset: 0x002D1EB8
		public unsafe string MainText
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x002D3CFC File Offset: 0x002D1EFC
		// (set) Token: 0x0600B610 RID: 46608 RVA: 0x002D3D3C File Offset: 0x002D1F3C
		public unsafe RectTransform UI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600B611 RID: 46609 RVA: 0x002D3D80 File Offset: 0x002D1F80
		// (set) Token: 0x0600B612 RID: 46610 RVA: 0x002D3DC0 File Offset: 0x002D1FC0
		public unsafe RectTransform IconContainer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x002D3E04 File Offset: 0x002D2004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310742, XrefRangeEnd = 310767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x002D3E38 File Offset: 0x002D2038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310767, XrefRangeEnd = 310776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x002D3E6C File Offset: 0x002D206C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310776, XrefRangeEnd = 310783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x002D3EA0 File Offset: 0x002D20A0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 310788, RefRangeEnd = 310802, XrefRangeStart = 310783, XrefRangeEnd = 310788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMainText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x002D3EE4 File Offset: 0x002D20E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310802, XrefRangeEnd = 310827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x002D3F20 File Offset: 0x002D2120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310915, RefRangeEnd = 310916, XrefRangeStart = 310827, XrefRangeEnd = 310915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x002D3F5C File Offset: 0x002D215C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310916, XrefRangeEnd = 310917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B61A RID: 46618 RVA: 0x002D3F98 File Offset: 0x002D2198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310917, XrefRangeEnd = 310918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B61B RID: 46619 RVA: 0x002D3FD4 File Offset: 0x002D21D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310918, XrefRangeEnd = 310925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x002D4010 File Offset: 0x002D2210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe POI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x002D404C File Offset: 0x002D224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310925, XrefRangeEnd = 310930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x002D408C File Offset: 0x002D228C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310930, RefRangeEnd = 310932, XrefRangeStart = 310930, XrefRangeEnd = 310930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x002D40D0 File Offset: 0x002D22D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38034, RefRangeEnd = 38039, XrefRangeStart = 38034, XrefRangeEnd = 38039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x002D4114 File Offset: 0x002D2314
		[CallerCount(0)]
		public unsafe void _InitializeUI_b__32_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x000595C6 File Offset: 0x000577C6
		public POI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600B622 RID: 46626 RVA: 0x002D4148 File Offset: 0x002D2348
		// (set) Token: 0x0600B623 RID: 46627 RVA: 0x000595CF File Offset: 0x000577CF
		public unsafe bool _UISetup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField)) = value;
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600B624 RID: 46628 RVA: 0x002D4170 File Offset: 0x002D2370
		// (set) Token: 0x0600B625 RID: 46629 RVA: 0x000595EA File Offset: 0x000577EA
		public unsafe POI.TextShowMode MainTextVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility)) = value;
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600B626 RID: 46630 RVA: 0x002D4198 File Offset: 0x002D2398
		// (set) Token: 0x0600B627 RID: 46631 RVA: 0x00059605 File Offset: 0x00057805
		public unsafe string DefaultMainText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600B628 RID: 46632 RVA: 0x002D41C0 File Offset: 0x002D23C0
		// (set) Token: 0x0600B629 RID: 46633 RVA: 0x00059624 File Offset: 0x00057824
		public unsafe bool AutoUpdatePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition)) = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600B62A RID: 46634 RVA: 0x002D41E8 File Offset: 0x002D23E8
		// (set) Token: 0x0600B62B RID: 46635 RVA: 0x0005963F File Offset: 0x0005783F
		public unsafe bool Rotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate)) = value;
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600B62C RID: 46636 RVA: 0x002D4210 File Offset: 0x002D2410
		// (set) Token: 0x0600B62D RID: 46637 RVA: 0x0005965A File Offset: 0x0005785A
		public unsafe string _MainText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600B62E RID: 46638 RVA: 0x002D4238 File Offset: 0x002D2438
		// (set) Token: 0x0600B62F RID: 46639 RVA: 0x00059679 File Offset: 0x00057879
		public unsafe GameObject UIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600B630 RID: 46640 RVA: 0x002D4268 File Offset: 0x002D2468
		// (set) Token: 0x0600B631 RID: 46641 RVA: 0x00059698 File Offset: 0x00057898
		public unsafe RectTransform _UI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600B632 RID: 46642 RVA: 0x002D4298 File Offset: 0x002D2498
		// (set) Token: 0x0600B633 RID: 46643 RVA: 0x000596B7 File Offset: 0x000578B7
		public unsafe RectTransform _IconContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600B634 RID: 46644 RVA: 0x002D42C8 File Offset: 0x002D24C8
		// (set) Token: 0x0600B635 RID: 46645 RVA: 0x000596D6 File Offset: 0x000578D6
		public unsafe Text mainLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600B636 RID: 46646 RVA: 0x002D42F8 File Offset: 0x002D24F8
		// (set) Token: 0x0600B637 RID: 46647 RVA: 0x000596F5 File Offset: 0x000578F5
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600B638 RID: 46648 RVA: 0x002D4328 File Offset: 0x002D2528
		// (set) Token: 0x0600B639 RID: 46649 RVA: 0x00059714 File Offset: 0x00057914
		public unsafe EventTrigger eventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600B63A RID: 46650 RVA: 0x002D4358 File Offset: 0x002D2558
		// (set) Token: 0x0600B63B RID: 46651 RVA: 0x00059733 File Offset: 0x00057933
		public unsafe bool mainTextSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet)) = value;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600B63C RID: 46652 RVA: 0x002D4380 File Offset: 0x002D2580
		// (set) Token: 0x0600B63D RID: 46653 RVA: 0x0005974E File Offset: 0x0005794E
		public unsafe UnityEvent onUICreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007AA4 RID: 31396
		private static readonly IntPtr NativeFieldInfoPtr__UISetup_k__BackingField;

		// Token: 0x04007AA5 RID: 31397
		private static readonly IntPtr NativeFieldInfoPtr_MainTextVisibility;

		// Token: 0x04007AA6 RID: 31398
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMainText;

		// Token: 0x04007AA7 RID: 31399
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdatePosition;

		// Token: 0x04007AA8 RID: 31400
		private static readonly IntPtr NativeFieldInfoPtr_Rotate;

		// Token: 0x04007AA9 RID: 31401
		private static readonly IntPtr NativeFieldInfoPtr__MainText_k__BackingField;

		// Token: 0x04007AAA RID: 31402
		private static readonly IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x04007AAB RID: 31403
		private static readonly IntPtr NativeFieldInfoPtr__UI_k__BackingField;

		// Token: 0x04007AAC RID: 31404
		private static readonly IntPtr NativeFieldInfoPtr__IconContainer_k__BackingField;

		// Token: 0x04007AAD RID: 31405
		private static readonly IntPtr NativeFieldInfoPtr_mainLabel;

		// Token: 0x04007AAE RID: 31406
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04007AAF RID: 31407
		private static readonly IntPtr NativeFieldInfoPtr_eventTrigger;

		// Token: 0x04007AB0 RID: 31408
		private static readonly IntPtr NativeFieldInfoPtr_mainTextSet;

		// Token: 0x04007AB1 RID: 31409
		private static readonly IntPtr NativeFieldInfoPtr_onUICreated;

		// Token: 0x04007AB2 RID: 31410
		private static readonly IntPtr NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0;

		// Token: 0x04007AB3 RID: 31411
		private static readonly IntPtr NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0;

		// Token: 0x04007AB4 RID: 31412
		private static readonly IntPtr NativeMethodInfoPtr_get_MainText_Public_get_String_0;

		// Token: 0x04007AB5 RID: 31413
		private static readonly IntPtr NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0;

		// Token: 0x04007AB6 RID: 31414
		private static readonly IntPtr NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0;

		// Token: 0x04007AB7 RID: 31415
		private static readonly IntPtr NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0;

		// Token: 0x04007AB8 RID: 31416
		private static readonly IntPtr NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0;

		// Token: 0x04007AB9 RID: 31417
		private static readonly IntPtr NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x04007ABA RID: 31418
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007ABB RID: 31419
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04007ABC RID: 31420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007ABD RID: 31421
		private static readonly IntPtr NativeMethodInfoPtr_SetMainText_Public_Void_String_0;

		// Token: 0x04007ABE RID: 31422
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0;

		// Token: 0x04007ABF RID: 31423
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0;

		// Token: 0x04007AC0 RID: 31424
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0;

		// Token: 0x04007AC1 RID: 31425
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0;

		// Token: 0x04007AC2 RID: 31426
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x04007AC3 RID: 31427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007AC4 RID: 31428
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007AC5 RID: 31429
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0;

		// Token: 0x04007AC6 RID: 31430
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0;

		// Token: 0x04007AC7 RID: 31431
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0;

		// Token: 0x02000C02 RID: 3074
		[OriginalName("Assembly-CSharp.dll", "", "TextShowMode")]
		public enum TextShowMode
		{
			// Token: 0x04009607 RID: 38407
			Off,
			// Token: 0x04009608 RID: 38408
			Always,
			// Token: 0x04009609 RID: 38409
			OnHover
		}

		// Token: 0x02000C03 RID: 3075
		[ObfuscatedName("ScheduleOne.Map.POI+<<OnEnable>g__Wait|27_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E00D RID: 57357 RVA: 0x0034C2E4 File Offset: 0x0034A4E4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique()
			{
				Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<<OnEnable>g__Wait|27_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>1__state");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>2__current");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>4__this");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685699);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685700);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685701);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685702);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685703);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685704);
			}

			// Token: 0x0600E00E RID: 57358 RVA: 0x0034C3C4 File Offset: 0x0034A5C4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E00F RID: 57359 RVA: 0x0034C40C File Offset: 0x0034A60C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E010 RID: 57360 RVA: 0x0034C440 File Offset: 0x0034A640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310705, XrefRangeEnd = 310729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004570 RID: 17776
			// (get) Token: 0x0600E011 RID: 57361 RVA: 0x0034C47C File Offset: 0x0034A67C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E012 RID: 57362 RVA: 0x0034C4BC File Offset: 0x0034A6BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310729, XrefRangeEnd = 310734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004571 RID: 17777
			// (get) Token: 0x0600E013 RID: 57363 RVA: 0x0034C4F0 File Offset: 0x0034A6F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E014 RID: 57364 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456D RID: 17773
			// (get) Token: 0x0600E015 RID: 57365 RVA: 0x0034C530 File Offset: 0x0034A730
			// (set) Token: 0x0600E016 RID: 57366 RVA: 0x0006D3DD File Offset: 0x0006B5DD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700456E RID: 17774
			// (get) Token: 0x0600E017 RID: 57367 RVA: 0x0034C558 File Offset: 0x0034A758
			// (set) Token: 0x0600E018 RID: 57368 RVA: 0x0006D3F8 File Offset: 0x0006B5F8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456F RID: 17775
			// (get) Token: 0x0600E019 RID: 57369 RVA: 0x0034C588 File Offset: 0x0034A788
			// (set) Token: 0x0600E01A RID: 57370 RVA: 0x0006D417 File Offset: 0x0006B617
			public unsafe POI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400960A RID: 38410
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400960B RID: 38411
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400960C RID: 38412
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400960D RID: 38413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400960E RID: 38414
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400960F RID: 38415
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009610 RID: 38416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009611 RID: 38417
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009612 RID: 38418
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C04 RID: 3076
		[ObfuscatedName("ScheduleOne.Map.POI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E01B RID: 57371 RVA: 0x0034C5B8 File Offset: 0x0034A7B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<POI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.__c>.NativeClassPtr);
				POI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9");
				POI.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9__27_1");
				POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100685706);
				POI.__c.NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100685707);
			}

			// Token: 0x0600E01C RID: 57372 RVA: 0x0034C634 File Offset: 0x0034A834
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E01D RID: 57373 RVA: 0x0034C670 File Offset: 0x0034A870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310734, XrefRangeEnd = 310742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__27_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E01E RID: 57374 RVA: 0x0006D436 File Offset: 0x0006B636
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004572 RID: 17778
			// (get) Token: 0x0600E01F RID: 57375 RVA: 0x0034C6AC File Offset: 0x0034A8AC
			// (set) Token: 0x0600E020 RID: 57376 RVA: 0x0006D43F File Offset: 0x0006B63F
			public unsafe static POI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004573 RID: 17779
			// (get) Token: 0x0600E021 RID: 57377 RVA: 0x0034C6D4 File Offset: 0x0034A8D4
			// (set) Token: 0x0600E022 RID: 57378 RVA: 0x0006D451 File Offset: 0x0006B651
			public unsafe static Func<bool> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009613 RID: 38419
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009614 RID: 38420
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04009615 RID: 38421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009616 RID: 38422
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0;
		}
	}
}
