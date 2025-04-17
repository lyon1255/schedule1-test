using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F2 RID: 1010
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x06005381 RID: 21377 RVA: 0x00189424 File Offset: 0x00187624
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionManager()
		{
			Il2CppClassPointerStore<InteractionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr);
			InteractionManager.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "RayRadius");
			InteractionManager.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "MaxInteractionRange");
			InteractionManager.NativeFieldInfoPtr_interaction_SearchMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_SearchMask");
			InteractionManager.NativeFieldInfoPtr_rightClickRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "rightClickRange");
			InteractionManager.NativeFieldInfoPtr_interactionSearchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionSearchType");
			InteractionManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "DEBUG");
			InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<CanDestroy>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_messageColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default_Key");
			InteractionManager.NativeFieldInfoPtr_messageColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_iconColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_icon_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Key");
			InteractionManager.NativeFieldInfoPtr_icon_LeftMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_LeftMouse");
			InteractionManager.NativeFieldInfoPtr_icon_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Cross");
			InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "displaySizeMultiplier");
			InteractionManager.NativeFieldInfoPtr_interaction_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_Canvas");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_Container");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_Icon");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_IconText");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_MessageText");
			InteractionManager.NativeFieldInfoPtr_wsLabelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "wsLabelContainer");
			InteractionManager.NativeFieldInfoPtr_InteractInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractInput");
			InteractionManager.NativeFieldInfoPtr_InteractKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractKey");
			InteractionManager.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "backgroundImage");
			InteractionManager.NativeFieldInfoPtr_WSLabelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "WSLabelPrefab");
			InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<hoveredInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<hoveredValidInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<interactedObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplayEnabledThisFrame");
			InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "itemBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "palletBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "constructableBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_destroyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "destroyTime");
			InteractionManager.NativeFieldInfoPtr_tempDisplayScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "tempDisplayScale");
			InteractionManager.NativeFieldInfoPtr_interactCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactCooldown");
			InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeSinceLastInteractStart");
			InteractionManager.NativeFieldInfoPtr_activeWSlabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "activeWSlabels");
			InteractionManager.NativeFieldInfoPtr_timeToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeToDestroy");
			InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "ILerpDisplayScale_Coroutine");
			InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673731);
			InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673732);
			InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673733);
			InteractionManager.NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673734);
			InteractionManager.NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673735);
			InteractionManager.NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673736);
			InteractionManager.NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673737);
			InteractionManager.NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673738);
			InteractionManager.NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673739);
			InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673740);
			InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673741);
			InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673742);
			InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673743);
			InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673744);
			InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673745);
			InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673746);
			InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673747);
			InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673748);
			InteractionManager.NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673749);
			InteractionManager.NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673750);
			InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673751);
			InteractionManager.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673752);
			InteractionManager.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673753);
			InteractionManager.NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673754);
			InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673755);
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06005382 RID: 21378 RVA: 0x00189968 File Offset: 0x00187B68
		public unsafe LayerMask Interaction_SearchMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06005383 RID: 21379 RVA: 0x001899A4 File Offset: 0x00187BA4
		// (set) Token: 0x06005384 RID: 21380 RVA: 0x001899E0 File Offset: 0x00187BE0
		public unsafe bool CanDestroy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06005385 RID: 21381 RVA: 0x00189A20 File Offset: 0x00187C20
		// (set) Token: 0x06005386 RID: 21382 RVA: 0x00189A60 File Offset: 0x00187C60
		public unsafe InteractableObject hoveredInteractableObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178997, XrefRangeEnd = 178998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x00189AA4 File Offset: 0x00187CA4
		// (set) Token: 0x06005388 RID: 21384 RVA: 0x00189AE4 File Offset: 0x00187CE4
		public unsafe InteractableObject hoveredValidInteractableObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06005389 RID: 21385 RVA: 0x00189B28 File Offset: 0x00187D28
		// (set) Token: 0x0600538A RID: 21386 RVA: 0x00189B68 File Offset: 0x00187D68
		public unsafe InteractableObject interactedObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00189BAC File Offset: 0x00187DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178998, XrefRangeEnd = 179042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00189BE8 File Offset: 0x00187DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179042, XrefRangeEnd = 179066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00189C24 File Offset: 0x00187E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179066, XrefRangeEnd = 179074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInteractKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00189C58 File Offset: 0x00187E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179074, XrefRangeEnd = 179078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00189C94 File Offset: 0x00187E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179078, XrefRangeEnd = 179095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00189CD0 File Offset: 0x00187ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179095, XrefRangeEnd = 179307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00189D0C File Offset: 0x00187F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179307, XrefRangeEnd = 179348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00189D48 File Offset: 0x00187F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179348, XrefRangeEnd = 179386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckRightClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00189D84 File Offset: 0x00187F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179386, XrefRangeEnd = 179396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BuildableItem GetHoveredBuildableItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00189DD0 File Offset: 0x00187FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179396, XrefRangeEnd = 179412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Pallet GetHoveredPallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr3) : null;
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00189E1C File Offset: 0x0018801C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179412, XrefRangeEnd = 179422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00189E68 File Offset: 0x00188068
		[CallerCount(0)]
		public unsafe void SetCanDestroy(bool canDestroy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canDestroy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00189EA8 File Offset: 0x001880A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179422, XrefRangeEnd = 179455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spriteText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iconColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00189F3C File Offset: 0x0018813C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179463, RefRangeEnd = 179465, XrefRangeStart = 179455, XrefRangeEnd = 179463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpDisplayScale(float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00189F7C File Offset: 0x0018817C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179465, XrefRangeEnd = 179470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startScale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00189FD8 File Offset: 0x001881D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179470, XrefRangeEnd = 179483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00027DBE File Offset: 0x00025FBE
		public InteractionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x0018A014 File Offset: 0x00188214
		// (set) Token: 0x0600539D RID: 21405 RVA: 0x00027DC7 File Offset: 0x00025FC7
		public unsafe static float RayRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&value));
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x0018A030 File Offset: 0x00188230
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x00027DD5 File Offset: 0x00025FD5
		public unsafe static float MaxInteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&value));
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x0018A04C File Offset: 0x0018824C
		// (set) Token: 0x060053A1 RID: 21409 RVA: 0x00027DE3 File Offset: 0x00025FE3
		public unsafe LayerMask interaction_SearchMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask)) = value;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x0018A074 File Offset: 0x00188274
		// (set) Token: 0x060053A3 RID: 21411 RVA: 0x00027DFE File Offset: 0x00025FFE
		public unsafe float rightClickRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange)) = value;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x0018A09C File Offset: 0x0018829C
		// (set) Token: 0x060053A5 RID: 21413 RVA: 0x00027E19 File Offset: 0x00026019
		public unsafe EInteractionSearchType interactionSearchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionSearchType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionSearchType)) = value;
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x0018A0C4 File Offset: 0x001882C4
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x00027E34 File Offset: 0x00026034
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x0018A0EC File Offset: 0x001882EC
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x00027E4F File Offset: 0x0002604F
		public unsafe bool _CanDestroy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField)) = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x060053AA RID: 21418 RVA: 0x0018A114 File Offset: 0x00188314
		// (set) Token: 0x060053AB RID: 21419 RVA: 0x00027E6A File Offset: 0x0002606A
		public unsafe Color messageColor_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default)) = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x0018A13C File Offset: 0x0018833C
		// (set) Token: 0x060053AD RID: 21421 RVA: 0x00027E85 File Offset: 0x00026085
		public unsafe Color iconColor_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default)) = value;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x0018A164 File Offset: 0x00188364
		// (set) Token: 0x060053AF RID: 21423 RVA: 0x00027EA0 File Offset: 0x000260A0
		public unsafe Color iconColor_Default_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key)) = value;
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x060053B0 RID: 21424 RVA: 0x0018A18C File Offset: 0x0018838C
		// (set) Token: 0x060053B1 RID: 21425 RVA: 0x00027EBB File Offset: 0x000260BB
		public unsafe Color messageColor_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid)) = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x060053B2 RID: 21426 RVA: 0x0018A1B4 File Offset: 0x001883B4
		// (set) Token: 0x060053B3 RID: 21427 RVA: 0x00027ED6 File Offset: 0x000260D6
		public unsafe Color iconColor_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid)) = value;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x0018A1DC File Offset: 0x001883DC
		// (set) Token: 0x060053B5 RID: 21429 RVA: 0x00027EF1 File Offset: 0x000260F1
		public unsafe Sprite icon_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x0018A20C File Offset: 0x0018840C
		// (set) Token: 0x060053B7 RID: 21431 RVA: 0x00027F10 File Offset: 0x00026110
		public unsafe Sprite icon_LeftMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x060053B8 RID: 21432 RVA: 0x0018A23C File Offset: 0x0018843C
		// (set) Token: 0x060053B9 RID: 21433 RVA: 0x00027F2F File Offset: 0x0002612F
		public unsafe Sprite icon_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x0018A26C File Offset: 0x0018846C
		// (set) Token: 0x060053BB RID: 21435 RVA: 0x00027F4E File Offset: 0x0002614E
		public unsafe float displaySizeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier)) = value;
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x060053BC RID: 21436 RVA: 0x0018A294 File Offset: 0x00188494
		// (set) Token: 0x060053BD RID: 21437 RVA: 0x00027F69 File Offset: 0x00026169
		public unsafe Canvas interaction_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060053BE RID: 21438 RVA: 0x0018A2C4 File Offset: 0x001884C4
		// (set) Token: 0x060053BF RID: 21439 RVA: 0x00027F88 File Offset: 0x00026188
		public unsafe RectTransform interactionDisplay_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x0018A2F4 File Offset: 0x001884F4
		// (set) Token: 0x060053C1 RID: 21441 RVA: 0x00027FA7 File Offset: 0x000261A7
		public unsafe Image interactionDisplay_Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x0018A324 File Offset: 0x00188524
		// (set) Token: 0x060053C3 RID: 21443 RVA: 0x00027FC6 File Offset: 0x000261C6
		public unsafe Text interactionDisplay_IconText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060053C4 RID: 21444 RVA: 0x0018A354 File Offset: 0x00188554
		// (set) Token: 0x060053C5 RID: 21445 RVA: 0x00027FE5 File Offset: 0x000261E5
		public unsafe Text interactionDisplay_MessageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x0018A384 File Offset: 0x00188584
		// (set) Token: 0x060053C7 RID: 21447 RVA: 0x00028004 File Offset: 0x00026204
		public unsafe RectTransform wsLabelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_wsLabelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_wsLabelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060053C8 RID: 21448 RVA: 0x0018A3B4 File Offset: 0x001885B4
		// (set) Token: 0x060053C9 RID: 21449 RVA: 0x00028023 File Offset: 0x00026223
		public unsafe InputActionReference InteractInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060053CA RID: 21450 RVA: 0x0018A3E4 File Offset: 0x001885E4
		// (set) Token: 0x060053CB RID: 21451 RVA: 0x00028042 File Offset: 0x00026242
		public unsafe string InteractKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060053CC RID: 21452 RVA: 0x0018A40C File Offset: 0x0018860C
		// (set) Token: 0x060053CD RID: 21453 RVA: 0x00028061 File Offset: 0x00026261
		public unsafe RectTransform backgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_backgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_backgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x0018A43C File Offset: 0x0018863C
		// (set) Token: 0x060053CF RID: 21455 RVA: 0x00028080 File Offset: 0x00026280
		public unsafe GameObject WSLabelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_WSLabelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_WSLabelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x0018A46C File Offset: 0x0018866C
		// (set) Token: 0x060053D1 RID: 21457 RVA: 0x0002809F File Offset: 0x0002629F
		public unsafe InteractableObject _hoveredInteractableObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060053D2 RID: 21458 RVA: 0x0018A49C File Offset: 0x0018869C
		// (set) Token: 0x060053D3 RID: 21459 RVA: 0x000280BE File Offset: 0x000262BE
		public unsafe InteractableObject _hoveredValidInteractableObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x0018A4CC File Offset: 0x001886CC
		// (set) Token: 0x060053D5 RID: 21461 RVA: 0x000280DD File Offset: 0x000262DD
		public unsafe InteractableObject _interactedObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060053D6 RID: 21462 RVA: 0x0018A4FC File Offset: 0x001886FC
		// (set) Token: 0x060053D7 RID: 21463 RVA: 0x000280FC File Offset: 0x000262FC
		public unsafe bool interactionDisplayEnabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame)) = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x0018A524 File Offset: 0x00188724
		// (set) Token: 0x060053D9 RID: 21465 RVA: 0x00028117 File Offset: 0x00026317
		public unsafe BuildableItem itemBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x0018A554 File Offset: 0x00188754
		// (set) Token: 0x060053DB RID: 21467 RVA: 0x00028136 File Offset: 0x00026336
		public unsafe Pallet palletBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x0018A584 File Offset: 0x00188784
		// (set) Token: 0x060053DD RID: 21469 RVA: 0x00028155 File Offset: 0x00026355
		public unsafe Constructable constructableBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x0018A5B4 File Offset: 0x001887B4
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x00028174 File Offset: 0x00026374
		public unsafe float destroyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime)) = value;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x0018A5DC File Offset: 0x001887DC
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x0002818F File Offset: 0x0002638F
		public unsafe float tempDisplayScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_tempDisplayScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_tempDisplayScale)) = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x0018A604 File Offset: 0x00188804
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x000281AA File Offset: 0x000263AA
		public unsafe static float interactCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&value));
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x0018A620 File Offset: 0x00188820
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x000281B8 File Offset: 0x000263B8
		public unsafe float timeSinceLastInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart)) = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0018A648 File Offset: 0x00188848
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x000281D3 File Offset: 0x000263D3
		public unsafe List<WorldSpaceLabel> activeWSlabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_activeWSlabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldSpaceLabel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_activeWSlabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x0018A678 File Offset: 0x00188878
		// (set) Token: 0x060053E9 RID: 21481 RVA: 0x000281F2 File Offset: 0x000263F2
		public unsafe static float timeToDestroy
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&value));
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x0018A694 File Offset: 0x00188894
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x00028200 File Offset: 0x00026400
		public unsafe Coroutine ILerpDisplayScale_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeFieldInfoPtr_interaction_SearchMask;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeFieldInfoPtr_rightClickRange;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeFieldInfoPtr_interactionSearchType;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeFieldInfoPtr__CanDestroy_k__BackingField;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeFieldInfoPtr_messageColor_Default;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Default;

		// Token: 0x040038A7 RID: 14503
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Default_Key;

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeFieldInfoPtr_messageColor_Invalid;

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Invalid;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeFieldInfoPtr_icon_Key;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeFieldInfoPtr_icon_LeftMouse;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeFieldInfoPtr_icon_Cross;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeFieldInfoPtr_displaySizeMultiplier;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeFieldInfoPtr_interaction_Canvas;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_Container;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_Icon;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_IconText;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_MessageText;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeFieldInfoPtr_wsLabelContainer;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeFieldInfoPtr_InteractInput;

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeFieldInfoPtr_InteractKey;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeFieldInfoPtr_backgroundImage;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeFieldInfoPtr_WSLabelPrefab;

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField;

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeFieldInfoPtr__interactedObject_k__BackingField;

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplayEnabledThisFrame;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeFieldInfoPtr_itemBeingDestroyed;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeFieldInfoPtr_palletBeingDestroyed;

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeFieldInfoPtr_constructableBeingDestroyed;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeFieldInfoPtr_destroyTime;

		// Token: 0x040038C0 RID: 14528
		private static readonly IntPtr NativeFieldInfoPtr_tempDisplayScale;

		// Token: 0x040038C1 RID: 14529
		private static readonly IntPtr NativeFieldInfoPtr_interactCooldown;

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastInteractStart;

		// Token: 0x040038C3 RID: 14531
		private static readonly IntPtr NativeFieldInfoPtr_activeWSlabels;

		// Token: 0x040038C4 RID: 14532
		private static readonly IntPtr NativeFieldInfoPtr_timeToDestroy;

		// Token: 0x040038C5 RID: 14533
		private static readonly IntPtr NativeFieldInfoPtr_ILerpDisplayScale_Coroutine;

		// Token: 0x040038C6 RID: 14534
		private static readonly IntPtr NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0;

		// Token: 0x040038C7 RID: 14535
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0;

		// Token: 0x040038C8 RID: 14536
		private static readonly IntPtr NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0;

		// Token: 0x040038C9 RID: 14537
		private static readonly IntPtr NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x040038CA RID: 14538
		private static readonly IntPtr NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040038CB RID: 14539
		private static readonly IntPtr NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x040038CC RID: 14540
		private static readonly IntPtr NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly IntPtr NativeMethodInfoPtr_LoadInteractKey_Private_Void_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040038D3 RID: 14547
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040038D4 RID: 14548
		private static readonly IntPtr NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0;

		// Token: 0x040038D5 RID: 14549
		private static readonly IntPtr NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0;

		// Token: 0x040038D6 RID: 14550
		private static readonly IntPtr NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0;

		// Token: 0x040038D7 RID: 14551
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0;

		// Token: 0x040038D8 RID: 14552
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0;

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B3 RID: 2483
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CBC3 RID: 52163 RVA: 0x00312CC4 File Offset: 0x00310EC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr);
				InteractionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9");
				InteractionManager.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9__57_0");
				InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100673758);
				InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100673759);
			}

			// Token: 0x0600CBC4 RID: 52164 RVA: 0x00312D40 File Offset: 0x00310F40
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBC5 RID: 52165 RVA: 0x00312D7C File Offset: 0x00310F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178972, XrefRangeEnd = 178975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__57_0(RaycastHit x, RaycastHit y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBC6 RID: 52166 RVA: 0x000631E0 File Offset: 0x000613E0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F7A RID: 16250
			// (get) Token: 0x0600CBC7 RID: 52167 RVA: 0x00312DD4 File Offset: 0x00310FD4
			// (set) Token: 0x0600CBC8 RID: 52168 RVA: 0x000631E9 File Offset: 0x000613E9
			public unsafe static InteractionManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F7B RID: 16251
			// (get) Token: 0x0600CBC9 RID: 52169 RVA: 0x00312DFC File Offset: 0x00310FFC
			// (set) Token: 0x0600CBCA RID: 52170 RVA: 0x000631FB File Offset: 0x000613FB
			public unsafe static Comparison<RaycastHit> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089C7 RID: 35271
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089C8 RID: 35272
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x040089C9 RID: 35273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089CA RID: 35274
			private static readonly IntPtr NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}

		// Token: 0x020009B4 RID: 2484
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBCB RID: 52171 RVA: 0x00312E24 File Offset: 0x00311024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr);
				InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, "objectHits");
				InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, 100673760);
				InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, 100673761);
			}

			// Token: 0x0600CBCC RID: 52172 RVA: 0x00312E8C File Offset: 0x0031108C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBCD RID: 52173 RVA: 0x00312EC8 File Offset: 0x003110C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178975, XrefRangeEnd = 178984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__1(InteractableObject x, InteractableObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBCE RID: 52174 RVA: 0x0006320D File Offset: 0x0006140D
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F7C RID: 16252
			// (get) Token: 0x0600CBCF RID: 52175 RVA: 0x00312F28 File Offset: 0x00311128
			// (set) Token: 0x0600CBD0 RID: 52176 RVA: 0x00063216 File Offset: 0x00061416
			public unsafe Dictionary<InteractableObject, RaycastHit> objectHits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InteractableObject, RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089CB RID: 35275
			private static readonly IntPtr NativeFieldInfoPtr_objectHits;

			// Token: 0x040089CC RID: 35276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089CD RID: 35277
			private static readonly IntPtr NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0;
		}

		// Token: 0x020009B5 RID: 2485
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<ILerpDisplayScale>d__68")]
		public sealed class _ILerpDisplayScale_d__68 : Il2CppSystem.Object
		{
			// Token: 0x0600CBD1 RID: 52177 RVA: 0x00312F58 File Offset: 0x00311158
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpDisplayScale_d__68()
			{
				Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<ILerpDisplayScale>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr);
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>1__state");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>2__current");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "startScale");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "endScale");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>4__this");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<lerpTime>5__2");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<i>5__3");
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673762);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673763);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673764);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673765);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673766);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673767);
			}

			// Token: 0x0600CBD2 RID: 52178 RVA: 0x00313088 File Offset: 0x00311288
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpDisplayScale_d__68(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBD3 RID: 52179 RVA: 0x003130D0 File Offset: 0x003112D0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBD4 RID: 52180 RVA: 0x00313104 File Offset: 0x00311304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178984, XrefRangeEnd = 178992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F84 RID: 16260
			// (get) Token: 0x0600CBD5 RID: 52181 RVA: 0x00313140 File Offset: 0x00311340
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBD6 RID: 52182 RVA: 0x00313180 File Offset: 0x00311380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178992, XrefRangeEnd = 178997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F85 RID: 16261
			// (get) Token: 0x0600CBD7 RID: 52183 RVA: 0x003131B4 File Offset: 0x003113B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBD8 RID: 52184 RVA: 0x00063235 File Offset: 0x00061435
			public _ILerpDisplayScale_d__68(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F7D RID: 16253
			// (get) Token: 0x0600CBD9 RID: 52185 RVA: 0x003131F4 File Offset: 0x003113F4
			// (set) Token: 0x0600CBDA RID: 52186 RVA: 0x0006323E File Offset: 0x0006143E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F7E RID: 16254
			// (get) Token: 0x0600CBDB RID: 52187 RVA: 0x0031321C File Offset: 0x0031141C
			// (set) Token: 0x0600CBDC RID: 52188 RVA: 0x00063259 File Offset: 0x00061459
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F7F RID: 16255
			// (get) Token: 0x0600CBDD RID: 52189 RVA: 0x0031324C File Offset: 0x0031144C
			// (set) Token: 0x0600CBDE RID: 52190 RVA: 0x00063278 File Offset: 0x00061478
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17003F80 RID: 16256
			// (get) Token: 0x0600CBDF RID: 52191 RVA: 0x00313274 File Offset: 0x00311474
			// (set) Token: 0x0600CBE0 RID: 52192 RVA: 0x00063293 File Offset: 0x00061493
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x17003F81 RID: 16257
			// (get) Token: 0x0600CBE1 RID: 52193 RVA: 0x0031329C File Offset: 0x0031149C
			// (set) Token: 0x0600CBE2 RID: 52194 RVA: 0x000632AE File Offset: 0x000614AE
			public unsafe InteractionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F82 RID: 16258
			// (get) Token: 0x0600CBE3 RID: 52195 RVA: 0x003132CC File Offset: 0x003114CC
			// (set) Token: 0x0600CBE4 RID: 52196 RVA: 0x000632CD File Offset: 0x000614CD
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17003F83 RID: 16259
			// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x003132F4 File Offset: 0x003114F4
			// (set) Token: 0x0600CBE6 RID: 52198 RVA: 0x000632E8 File Offset: 0x000614E8
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040089CE RID: 35278
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089CF RID: 35279
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089D0 RID: 35280
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x040089D1 RID: 35281
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x040089D2 RID: 35282
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089D3 RID: 35283
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x040089D4 RID: 35284
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040089D5 RID: 35285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089D6 RID: 35286
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089D7 RID: 35287
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089D8 RID: 35288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089D9 RID: 35289
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089DA RID: 35290
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
