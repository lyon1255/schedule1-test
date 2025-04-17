using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000474 RID: 1140
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x0600626E RID: 25198 RVA: 0x001BF6D8 File Offset: 0x001BD8D8
		// Note: this type is marked as 'beforefieldinit'.
		static RebindActionUI()
		{
			Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "RebindActionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr);
			RebindActionUI.NativeFieldInfoPtr_onRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "onRebind");
			RebindActionUI.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_Action");
			RebindActionUI.NativeFieldInfoPtr_m_BindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingId");
			RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_DisplayStringOptions");
			RebindActionUI.NativeFieldInfoPtr_m_ActionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_ActionLabel");
			RebindActionUI.NativeFieldInfoPtr_m_BindingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingText");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOverlay");
			RebindActionUI.NativeFieldInfoPtr_m_RebindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindText");
			RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_UpdateBindingUIEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStartEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStopEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOperation");
			RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "s_RebindActionUIs");
			RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675772);
			RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675773);
			RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675774);
			RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675775);
			RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675776);
			RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675777);
			RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675778);
			RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675779);
			RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675780);
			RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675781);
			RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675782);
			RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675783);
			RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675784);
			RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675785);
			RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675786);
			RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675787);
			RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675788);
			RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675789);
			RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675790);
			RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675791);
			RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675792);
			RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675793);
			RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675794);
			RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675795);
			RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675796);
			RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675797);
			RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675798);
			RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675799);
			RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675800);
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x0600626F RID: 25199 RVA: 0x001BFA50 File Offset: 0x001BDC50
		// (set) Token: 0x06006270 RID: 25200 RVA: 0x001BFA90 File Offset: 0x001BDC90
		public unsafe InputActionReference actionReference
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201938, XrefRangeEnd = 201941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x001BFAD4 File Offset: 0x001BDCD4
		// (set) Token: 0x06006272 RID: 25202 RVA: 0x001BFB0C File Offset: 0x001BDD0C
		public unsafe string bindingId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201941, XrefRangeEnd = 201943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06006273 RID: 25203 RVA: 0x001BFB50 File Offset: 0x001BDD50
		// (set) Token: 0x06006274 RID: 25204 RVA: 0x001BFB8C File Offset: 0x001BDD8C
		public unsafe InputBinding.DisplayStringOptions displayStringOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201943, XrefRangeEnd = 201944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06006275 RID: 25205 RVA: 0x001BFBCC File Offset: 0x001BDDCC
		// (set) Token: 0x06006276 RID: 25206 RVA: 0x001BFC0C File Offset: 0x001BDE0C
		public unsafe TextMeshProUGUI actionLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201944, XrefRangeEnd = 201946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06006277 RID: 25207 RVA: 0x001BFC50 File Offset: 0x001BDE50
		// (set) Token: 0x06006278 RID: 25208 RVA: 0x001BFC90 File Offset: 0x001BDE90
		public unsafe TextMeshProUGUI bindingText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201946, XrefRangeEnd = 201948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06006279 RID: 25209 RVA: 0x001BFCD4 File Offset: 0x001BDED4
		// (set) Token: 0x0600627A RID: 25210 RVA: 0x001BFD14 File Offset: 0x001BDF14
		public unsafe TextMeshProUGUI rebindPrompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600627B RID: 25211 RVA: 0x001BFD58 File Offset: 0x001BDF58
		// (set) Token: 0x0600627C RID: 25212 RVA: 0x001BFD98 File Offset: 0x001BDF98
		public unsafe GameObject rebindOverlay
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600627D RID: 25213 RVA: 0x001BFDDC File Offset: 0x001BDFDC
		public unsafe RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201948, XrefRangeEnd = 201955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x0600627E RID: 25214 RVA: 0x001BFE1C File Offset: 0x001BE01C
		public unsafe RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201955, XrefRangeEnd = 201962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x0600627F RID: 25215 RVA: 0x001BFE5C File Offset: 0x001BE05C
		public unsafe RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201962, XrefRangeEnd = 201969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x001BFE9C File Offset: 0x001BE09C
		public unsafe InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45797, RefRangeEnd = 45798, XrefRangeStart = 45797, XrefRangeEnd = 45798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x001BFEDC File Offset: 0x001BE0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201969, XrefRangeEnd = 201991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bindingIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			action = ((intPtr4 == 0) ? null : new InputAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x001BFF48 File Offset: 0x001BE148
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 202014, RefRangeEnd = 202024, XrefRangeStart = 201991, XrefRangeEnd = 202014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBindingDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x001BFF7C File Offset: 0x001BE17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202024, XrefRangeEnd = 202054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x001BFFB0 File Offset: 0x001BE1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202054, XrefRangeEnd = 202093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInteractiveRebind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x001BFFE4 File Offset: 0x001BE1E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202158, RefRangeEnd = 202160, XrefRangeStart = 202093, XrefRangeEnd = 202158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allCompositeParts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x001C0044 File Offset: 0x001BE244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202160, XrefRangeEnd = 202189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x001C0078 File Offset: 0x001BE278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202189, XrefRangeEnd = 202210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x001C00AC File Offset: 0x001BE2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202210, XrefRangeEnd = 202237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActionChange(Il2CppSystem.Object obj, InputActionChange change)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x001C00F0 File Offset: 0x001BE2F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202245, RefRangeEnd = 202247, XrefRangeStart = 202237, XrefRangeEnd = 202245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x001C0124 File Offset: 0x001BE324
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindActionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x001C0160 File Offset: 0x001BE360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202247, XrefRangeEnd = 202250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateBindingDisplay_b__31_0(InputBinding x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x0002E8AD File Offset: 0x0002CAAD
		public RebindActionUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x001C01B4 File Offset: 0x001BE3B4
		// (set) Token: 0x0600628E RID: 25230 RVA: 0x0002E8B6 File Offset: 0x0002CAB6
		public unsafe Action onRebind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x0600628F RID: 25231 RVA: 0x001C01E4 File Offset: 0x001BE3E4
		// (set) Token: 0x06006290 RID: 25232 RVA: 0x0002E8D5 File Offset: 0x0002CAD5
		public unsafe InputActionReference m_Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x001C0214 File Offset: 0x001BE414
		// (set) Token: 0x06006292 RID: 25234 RVA: 0x0002E8F4 File Offset: 0x0002CAF4
		public unsafe string m_BindingId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x001C023C File Offset: 0x001BE43C
		// (set) Token: 0x06006294 RID: 25236 RVA: 0x0002E913 File Offset: 0x0002CB13
		public unsafe InputBinding.DisplayStringOptions m_DisplayStringOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions)) = value;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x001C0264 File Offset: 0x001BE464
		// (set) Token: 0x06006296 RID: 25238 RVA: 0x0002E92E File Offset: 0x0002CB2E
		public unsafe TextMeshProUGUI m_ActionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06006297 RID: 25239 RVA: 0x001C0294 File Offset: 0x001BE494
		// (set) Token: 0x06006298 RID: 25240 RVA: 0x0002E94D File Offset: 0x0002CB4D
		public unsafe TextMeshProUGUI m_BindingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06006299 RID: 25241 RVA: 0x001C02C4 File Offset: 0x001BE4C4
		// (set) Token: 0x0600629A RID: 25242 RVA: 0x0002E96C File Offset: 0x0002CB6C
		public unsafe GameObject m_RebindOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x0600629B RID: 25243 RVA: 0x001C02F4 File Offset: 0x001BE4F4
		// (set) Token: 0x0600629C RID: 25244 RVA: 0x0002E98B File Offset: 0x0002CB8B
		public unsafe TextMeshProUGUI m_RebindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x0600629D RID: 25245 RVA: 0x001C0324 File Offset: 0x001BE524
		// (set) Token: 0x0600629E RID: 25246 RVA: 0x0002E9AA File Offset: 0x0002CBAA
		public unsafe RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x0600629F RID: 25247 RVA: 0x001C0354 File Offset: 0x001BE554
		// (set) Token: 0x060062A0 RID: 25248 RVA: 0x0002E9C9 File Offset: 0x0002CBC9
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x001C0384 File Offset: 0x001BE584
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x0002E9E8 File Offset: 0x0002CBE8
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStopEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x001C03B4 File Offset: 0x001BE5B4
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x0002EA07 File Offset: 0x0002CC07
		public unsafe InputActionRebindingExtensions.RebindingOperation m_RebindOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x001C03E4 File Offset: 0x001BE5E4
		// (set) Token: 0x060062A6 RID: 25254 RVA: 0x0002EA26 File Offset: 0x0002CC26
		public unsafe static List<RebindActionUI> s_RebindActionUIs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RebindActionUI>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400431F RID: 17183
		private static readonly IntPtr NativeFieldInfoPtr_onRebind;

		// Token: 0x04004320 RID: 17184
		private static readonly IntPtr NativeFieldInfoPtr_m_Action;

		// Token: 0x04004321 RID: 17185
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingId;

		// Token: 0x04004322 RID: 17186
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayStringOptions;

		// Token: 0x04004323 RID: 17187
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionLabel;

		// Token: 0x04004324 RID: 17188
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingText;

		// Token: 0x04004325 RID: 17189
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindOverlay;

		// Token: 0x04004326 RID: 17190
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindText;

		// Token: 0x04004327 RID: 17191
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateBindingUIEvent;

		// Token: 0x04004328 RID: 17192
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindStartEvent;

		// Token: 0x04004329 RID: 17193
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindStopEvent;

		// Token: 0x0400432A RID: 17194
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindOperation;

		// Token: 0x0400432B RID: 17195
		private static readonly IntPtr NativeFieldInfoPtr_s_RebindActionUIs;

		// Token: 0x0400432C RID: 17196
		private static readonly IntPtr NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0;

		// Token: 0x0400432D RID: 17197
		private static readonly IntPtr NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0;

		// Token: 0x0400432E RID: 17198
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingId_Public_get_String_0;

		// Token: 0x0400432F RID: 17199
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0;

		// Token: 0x04004330 RID: 17200
		private static readonly IntPtr NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0;

		// Token: 0x04004331 RID: 17201
		private static readonly IntPtr NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0;

		// Token: 0x04004332 RID: 17202
		private static readonly IntPtr NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004333 RID: 17203
		private static readonly IntPtr NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004334 RID: 17204
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004335 RID: 17205
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004336 RID: 17206
		private static readonly IntPtr NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004337 RID: 17207
		private static readonly IntPtr NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004338 RID: 17208
		private static readonly IntPtr NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0;

		// Token: 0x04004339 RID: 17209
		private static readonly IntPtr NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0;

		// Token: 0x0400433A RID: 17210
		private static readonly IntPtr NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0;

		// Token: 0x0400433B RID: 17211
		private static readonly IntPtr NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x0400433C RID: 17212
		private static readonly IntPtr NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x0400433D RID: 17213
		private static readonly IntPtr NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0;

		// Token: 0x0400433E RID: 17214
		private static readonly IntPtr NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0;

		// Token: 0x0400433F RID: 17215
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0;

		// Token: 0x04004340 RID: 17216
		private static readonly IntPtr NativeMethodInfoPtr_ResetToDefault_Public_Void_0;

		// Token: 0x04004341 RID: 17217
		private static readonly IntPtr NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0;

		// Token: 0x04004342 RID: 17218
		private static readonly IntPtr NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0;

		// Token: 0x04004343 RID: 17219
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x04004344 RID: 17220
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

		// Token: 0x04004345 RID: 17221
		private static readonly IntPtr NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0;

		// Token: 0x04004346 RID: 17222
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0;

		// Token: 0x04004347 RID: 17223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004348 RID: 17224
		private static readonly IntPtr NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0;

		// Token: 0x02000A20 RID: 2592
		[Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
			// Token: 0x0600CF03 RID: 52995 RVA: 0x00064B0F File Offset: 0x00062D0F
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateBindingUIEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "UpdateBindingUIEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr);
				RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr, 100675801);
			}

			// Token: 0x0600CF04 RID: 52996 RVA: 0x0031C0CC File Offset: 0x0031A2CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201898, XrefRangeEnd = 201901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateBindingUIEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF05 RID: 52997 RVA: 0x00064B43 File Offset: 0x00062D43
			public UpdateBindingUIEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008BB2 RID: 35762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A21 RID: 2593
		[Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
			// Token: 0x0600CF06 RID: 52998 RVA: 0x00064B4C File Offset: 0x00062D4C
			// Note: this type is marked as 'beforefieldinit'.
			static InteractiveRebindEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "InteractiveRebindEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr);
				RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr, 100675802);
			}

			// Token: 0x0600CF07 RID: 52999 RVA: 0x0031C108 File Offset: 0x0031A308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201901, XrefRangeEnd = 201904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InteractiveRebindEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF08 RID: 53000 RVA: 0x00064B80 File Offset: 0x00062D80
			public InteractiveRebindEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008BB3 RID: 35763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A22 RID: 2594
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF09 RID: 53001 RVA: 0x0031C144 File Offset: 0x0031A344
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, "bindingId");
				RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, 100675803);
				RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, 100675804);
			}

			// Token: 0x0600CF0A RID: 53002 RVA: 0x0031C1AC File Offset: 0x0031A3AC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF0B RID: 53003 RVA: 0x0031C1E8 File Offset: 0x0031A3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201904, XrefRangeEnd = 201906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveActionAndBinding_b__0(InputBinding x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF0C RID: 53004 RVA: 0x00064B89 File Offset: 0x00062D89
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405F RID: 16479
			// (get) Token: 0x0600CF0D RID: 53005 RVA: 0x0031C23C File Offset: 0x0031A43C
			// (set) Token: 0x0600CF0E RID: 53006 RVA: 0x00064B92 File Offset: 0x00062D92
			public unsafe Guid bindingId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId)) = value;
				}
			}

			// Token: 0x04008BB4 RID: 35764
			private static readonly IntPtr NativeFieldInfoPtr_bindingId;

			// Token: 0x04008BB5 RID: 35765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BB6 RID: 35766
			private static readonly IntPtr NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0;
		}

		// Token: 0x02000A23 RID: 2595
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF0F RID: 53007 RVA: 0x0031C264 File Offset: 0x0031A464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "allCompositeParts");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "bindingIndex");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "action");
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675805);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675806);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675807);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675808);
			}

			// Token: 0x0600CF10 RID: 53008 RVA: 0x0031C330 File Offset: 0x0031A530
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF11 RID: 53009 RVA: 0x0031C36C File Offset: 0x0031A56C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 201911, RefRangeEnd = 201913, XrefRangeStart = 201906, XrefRangeEnd = 201911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF12 RID: 53010 RVA: 0x0031C3A0 File Offset: 0x0031A5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201913, XrefRangeEnd = 201924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__1(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF13 RID: 53011 RVA: 0x0031C3E4 File Offset: 0x0031A5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201924, XrefRangeEnd = 201938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__2(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF14 RID: 53012 RVA: 0x00064BAD File Offset: 0x00062DAD
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004060 RID: 16480
			// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x0031C428 File Offset: 0x0031A628
			// (set) Token: 0x0600CF16 RID: 53014 RVA: 0x00064BB6 File Offset: 0x00062DB6
			public unsafe RebindActionUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004061 RID: 16481
			// (get) Token: 0x0600CF17 RID: 53015 RVA: 0x0031C458 File Offset: 0x0031A658
			// (set) Token: 0x0600CF18 RID: 53016 RVA: 0x00064BD5 File Offset: 0x00062DD5
			public unsafe bool allCompositeParts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts)) = value;
				}
			}

			// Token: 0x17004062 RID: 16482
			// (get) Token: 0x0600CF19 RID: 53017 RVA: 0x0031C480 File Offset: 0x0031A680
			// (set) Token: 0x0600CF1A RID: 53018 RVA: 0x00064BF0 File Offset: 0x00062DF0
			public unsafe int bindingIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex)) = value;
				}
			}

			// Token: 0x17004063 RID: 16483
			// (get) Token: 0x0600CF1B RID: 53019 RVA: 0x0031C4A8 File Offset: 0x0031A6A8
			// (set) Token: 0x0600CF1C RID: 53020 RVA: 0x00064C0B File Offset: 0x00062E0B
			public unsafe InputAction action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BB7 RID: 35767
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BB8 RID: 35768
			private static readonly IntPtr NativeFieldInfoPtr_allCompositeParts;

			// Token: 0x04008BB9 RID: 35769
			private static readonly IntPtr NativeFieldInfoPtr_bindingIndex;

			// Token: 0x04008BBA RID: 35770
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04008BBB RID: 35771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BBC RID: 35772
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04008BBD RID: 35773
			private static readonly IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0;

			// Token: 0x04008BBE RID: 35774
			private static readonly IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0;
		}
	}
}
