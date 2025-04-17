using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000719 RID: 1817
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		// Token: 0x0600A35F RID: 41823 RVA: 0x0028FE84 File Offset: 0x0028E084
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUIManager()
		{
			Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUIManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr);
			ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<DraggingEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<HoveredSlot>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<QuickMoveEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Canvas");
			ItemUIManager.NativeFieldInfoPtr_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Raycasters");
			ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashDragAmountContainer");
			ItemUIManager.NativeFieldInfoPtr_InputsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InputsContainer");
			ItemUIManager.NativeFieldInfoPtr_InfoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InfoPanel");
			ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemQuantityPrompt");
			ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashSlotHintAnim");
			ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashSlotHintAnimCanvasGroup");
			ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "DefaultItemUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "HotbarSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_draggedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedSlot");
			ItemUIManager.NativeFieldInfoPtr_mouseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "mouseOffset");
			ItemUIManager.NativeFieldInfoPtr_draggedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedAmount");
			ItemUIManager.NativeFieldInfoPtr_tempIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "tempIcon");
			ItemUIManager.NativeFieldInfoPtr_isDraggingCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "isDraggingCash");
			ItemUIManager.NativeFieldInfoPtr_draggedCashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedCashAmount");
			ItemUIManager.NativeFieldInfoPtr_PrimarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "PrimarySlots");
			ItemUIManager.NativeFieldInfoPtr_SecondarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "SecondarySlots");
			ItemUIManager.NativeFieldInfoPtr_customDragAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "customDragAmount");
			ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "quantityChangePopRoutine");
			ItemUIManager.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onDragStart");
			ItemUIManager.NativeFieldInfoPtr_onItemMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onItemMoved");
			ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683277);
			ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683278);
			ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683279);
			ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683280);
			ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683281);
			ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683282);
			ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683283);
			ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683284);
			ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683285);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683286);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683287);
			ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683288);
			ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683289);
			ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683290);
			ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683291);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683292);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683293);
			ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683294);
			ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683295);
			ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683296);
			ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683297);
			ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683298);
			ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683299);
			ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683300);
			ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683301);
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A360 RID: 41824 RVA: 0x002902B0 File Offset: 0x0028E4B0
		// (set) Token: 0x0600A361 RID: 41825 RVA: 0x002902EC File Offset: 0x0028E4EC
		public unsafe bool DraggingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A362 RID: 41826 RVA: 0x0029032C File Offset: 0x0028E52C
		// (set) Token: 0x0600A363 RID: 41827 RVA: 0x0029036C File Offset: 0x0028E56C
		public unsafe ItemSlotUI HoveredSlot
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A364 RID: 41828 RVA: 0x002903B0 File Offset: 0x0028E5B0
		// (set) Token: 0x0600A365 RID: 41829 RVA: 0x002903EC File Offset: 0x0028E5EC
		public unsafe bool QuickMoveEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x0029042C File Offset: 0x0028E62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285728, XrefRangeEnd = 285736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x00290468 File Offset: 0x0028E668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285736, XrefRangeEnd = 285808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x002904A4 File Offset: 0x0028E6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285808, XrefRangeEnd = 285820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x002904E0 File Offset: 0x0028E6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285841, RefRangeEnd = 285842, XrefRangeStart = 285820, XrefRangeEnd = 285841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragSelectorUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x00290514 File Offset: 0x0028E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285842, XrefRangeEnd = 285864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragAmount(CashInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x00290558 File Offset: 0x0028E758
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 285879, RefRangeEnd = 285900, XrefRangeStart = 285864, XrefRangeEnd = 285879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifierPromptsVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x002905A4 File Offset: 0x0028E7A4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 285920, RefRangeEnd = 285933, XrefRangeStart = 285900, XrefRangeEnd = 285920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primarySlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondarySlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x002905F8 File Offset: 0x0028E7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285968, RefRangeEnd = 285970, XrefRangeStart = 285933, XrefRangeEnd = 285968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSlot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x00290648 File Offset: 0x0028E848
		[CallerCount(0)]
		public unsafe void DisableQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x0029067C File Offset: 0x0028E87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286002, RefRangeEnd = 286003, XrefRangeStart = 285970, XrefRangeEnd = 286002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredItemSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x002906BC File Offset: 0x0028E8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286032, RefRangeEnd = 286033, XrefRangeStart = 286003, XrefRangeEnd = 286032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinitionInfoHoverable>(intPtr3) : null;
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x002906FC File Offset: 0x0028E8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286081, RefRangeEnd = 286082, XrefRangeStart = 286033, XrefRangeEnd = 286081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotClicked(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x00290740 File Offset: 0x0028E940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286082, XrefRangeEnd = 286131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x00290774 File Offset: 0x0028E974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286175, RefRangeEnd = 286177, XrefRangeStart = 286131, XrefRangeEnd = 286175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x002907A8 File Offset: 0x0028E9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286218, RefRangeEnd = 286219, XrefRangeStart = 286177, XrefRangeEnd = 286218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggedAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x002907E8 File Offset: 0x0028E9E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286283, RefRangeEnd = 286284, XrefRangeStart = 286219, XrefRangeEnd = 286283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCashDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x0029081C File Offset: 0x0028EA1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286289, RefRangeEnd = 286291, XrefRangeStart = 286284, XrefRangeEnd = 286289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A377 RID: 41847 RVA: 0x0029086C File Offset: 0x0028EA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286291, XrefRangeEnd = 286297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x002908BC File Offset: 0x0028EABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286297, XrefRangeEnd = 286314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x00050705 File Offset: 0x0004E905
		public ItemUIManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x002908F8 File Offset: 0x0028EAF8
		// (set) Token: 0x0600A37B RID: 41851 RVA: 0x0005070E File Offset: 0x0004E90E
		public unsafe bool _DraggingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600A37C RID: 41852 RVA: 0x00290920 File Offset: 0x0028EB20
		// (set) Token: 0x0600A37D RID: 41853 RVA: 0x00050729 File Offset: 0x0004E929
		public unsafe ItemSlotUI _HoveredSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A37E RID: 41854 RVA: 0x00290950 File Offset: 0x0028EB50
		// (set) Token: 0x0600A37F RID: 41855 RVA: 0x00050748 File Offset: 0x0004E948
		public unsafe bool _QuickMoveEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x00290978 File Offset: 0x0028EB78
		// (set) Token: 0x0600A381 RID: 41857 RVA: 0x00050763 File Offset: 0x0004E963
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A382 RID: 41858 RVA: 0x002909A8 File Offset: 0x0028EBA8
		// (set) Token: 0x0600A383 RID: 41859 RVA: 0x00050782 File Offset: 0x0004E982
		public unsafe Il2CppReferenceArray<GraphicRaycaster> Raycasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Raycasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A384 RID: 41860 RVA: 0x002909D8 File Offset: 0x0028EBD8
		// (set) Token: 0x0600A385 RID: 41861 RVA: 0x000507A1 File Offset: 0x0004E9A1
		public unsafe RectTransform CashDragAmountContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A386 RID: 41862 RVA: 0x00290A08 File Offset: 0x0028EC08
		// (set) Token: 0x0600A387 RID: 41863 RVA: 0x000507C0 File Offset: 0x0004E9C0
		public unsafe RectTransform InputsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InputsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InputsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A388 RID: 41864 RVA: 0x00290A38 File Offset: 0x0028EC38
		// (set) Token: 0x0600A389 RID: 41865 RVA: 0x000507DF File Offset: 0x0004E9DF
		public unsafe ItemInfoPanel InfoPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A38A RID: 41866 RVA: 0x00290A68 File Offset: 0x0028EC68
		// (set) Token: 0x0600A38B RID: 41867 RVA: 0x000507FE File Offset: 0x0004E9FE
		public unsafe RectTransform ItemQuantityPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A38C RID: 41868 RVA: 0x00290A98 File Offset: 0x0028EC98
		// (set) Token: 0x0600A38D RID: 41869 RVA: 0x0005081D File Offset: 0x0004EA1D
		public unsafe Animation CashSlotHintAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A38E RID: 41870 RVA: 0x00290AC8 File Offset: 0x0028ECC8
		// (set) Token: 0x0600A38F RID: 41871 RVA: 0x0005083C File Offset: 0x0004EA3C
		public unsafe CanvasGroup CashSlotHintAnimCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A390 RID: 41872 RVA: 0x00290AF8 File Offset: 0x0028ECF8
		// (set) Token: 0x0600A391 RID: 41873 RVA: 0x0005085B File Offset: 0x0004EA5B
		public unsafe ItemSlotUI ItemSlotUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x00290B28 File Offset: 0x0028ED28
		// (set) Token: 0x0600A393 RID: 41875 RVA: 0x0005087A File Offset: 0x0004EA7A
		public unsafe ItemUI DefaultItemUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A394 RID: 41876 RVA: 0x00290B58 File Offset: 0x0028ED58
		// (set) Token: 0x0600A395 RID: 41877 RVA: 0x00050899 File Offset: 0x0004EA99
		public unsafe ItemSlotUI HotbarSlotUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A396 RID: 41878 RVA: 0x00290B88 File Offset: 0x0028ED88
		// (set) Token: 0x0600A397 RID: 41879 RVA: 0x000508B8 File Offset: 0x0004EAB8
		public unsafe ItemSlotUI draggedSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A398 RID: 41880 RVA: 0x00290BB8 File Offset: 0x0028EDB8
		// (set) Token: 0x0600A399 RID: 41881 RVA: 0x000508D7 File Offset: 0x0004EAD7
		public unsafe Vector2 mouseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset)) = value;
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A39A RID: 41882 RVA: 0x00290BE0 File Offset: 0x0028EDE0
		// (set) Token: 0x0600A39B RID: 41883 RVA: 0x000508F2 File Offset: 0x0004EAF2
		public unsafe int draggedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount)) = value;
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A39C RID: 41884 RVA: 0x00290C08 File Offset: 0x0028EE08
		// (set) Token: 0x0600A39D RID: 41885 RVA: 0x0005090D File Offset: 0x0004EB0D
		public unsafe RectTransform tempIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A39E RID: 41886 RVA: 0x00290C38 File Offset: 0x0028EE38
		// (set) Token: 0x0600A39F RID: 41887 RVA: 0x0005092C File Offset: 0x0004EB2C
		public unsafe bool isDraggingCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash)) = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A3A0 RID: 41888 RVA: 0x00290C60 File Offset: 0x0028EE60
		// (set) Token: 0x0600A3A1 RID: 41889 RVA: 0x00050947 File Offset: 0x0004EB47
		public unsafe float draggedCashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount)) = value;
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A3A2 RID: 41890 RVA: 0x00290C88 File Offset: 0x0028EE88
		// (set) Token: 0x0600A3A3 RID: 41891 RVA: 0x00050962 File Offset: 0x0004EB62
		public unsafe List<ItemSlot> PrimarySlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A3A4 RID: 41892 RVA: 0x00290CB8 File Offset: 0x0028EEB8
		// (set) Token: 0x0600A3A5 RID: 41893 RVA: 0x00050981 File Offset: 0x0004EB81
		public unsafe List<ItemSlot> SecondarySlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x00290CE8 File Offset: 0x0028EEE8
		// (set) Token: 0x0600A3A7 RID: 41895 RVA: 0x000509A0 File Offset: 0x0004EBA0
		public unsafe bool customDragAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount)) = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A3A8 RID: 41896 RVA: 0x00290D10 File Offset: 0x0028EF10
		// (set) Token: 0x0600A3A9 RID: 41897 RVA: 0x000509BB File Offset: 0x0004EBBB
		public unsafe Coroutine quantityChangePopRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A3AA RID: 41898 RVA: 0x00290D40 File Offset: 0x0028EF40
		// (set) Token: 0x0600A3AB RID: 41899 RVA: 0x000509DA File Offset: 0x0004EBDA
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A3AC RID: 41900 RVA: 0x00290D70 File Offset: 0x0028EF70
		// (set) Token: 0x0600A3AD RID: 41901 RVA: 0x000509F9 File Offset: 0x0004EBF9
		public unsafe UnityEvent onItemMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D8F RID: 28047
		private static readonly IntPtr NativeFieldInfoPtr__DraggingEnabled_k__BackingField;

		// Token: 0x04006D90 RID: 28048
		private static readonly IntPtr NativeFieldInfoPtr__HoveredSlot_k__BackingField;

		// Token: 0x04006D91 RID: 28049
		private static readonly IntPtr NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField;

		// Token: 0x04006D92 RID: 28050
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006D93 RID: 28051
		private static readonly IntPtr NativeFieldInfoPtr_Raycasters;

		// Token: 0x04006D94 RID: 28052
		private static readonly IntPtr NativeFieldInfoPtr_CashDragAmountContainer;

		// Token: 0x04006D95 RID: 28053
		private static readonly IntPtr NativeFieldInfoPtr_InputsContainer;

		// Token: 0x04006D96 RID: 28054
		private static readonly IntPtr NativeFieldInfoPtr_InfoPanel;

		// Token: 0x04006D97 RID: 28055
		private static readonly IntPtr NativeFieldInfoPtr_ItemQuantityPrompt;

		// Token: 0x04006D98 RID: 28056
		private static readonly IntPtr NativeFieldInfoPtr_CashSlotHintAnim;

		// Token: 0x04006D99 RID: 28057
		private static readonly IntPtr NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup;

		// Token: 0x04006D9A RID: 28058
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotUIPrefab;

		// Token: 0x04006D9B RID: 28059
		private static readonly IntPtr NativeFieldInfoPtr_DefaultItemUIPrefab;

		// Token: 0x04006D9C RID: 28060
		private static readonly IntPtr NativeFieldInfoPtr_HotbarSlotUIPrefab;

		// Token: 0x04006D9D RID: 28061
		private static readonly IntPtr NativeFieldInfoPtr_draggedSlot;

		// Token: 0x04006D9E RID: 28062
		private static readonly IntPtr NativeFieldInfoPtr_mouseOffset;

		// Token: 0x04006D9F RID: 28063
		private static readonly IntPtr NativeFieldInfoPtr_draggedAmount;

		// Token: 0x04006DA0 RID: 28064
		private static readonly IntPtr NativeFieldInfoPtr_tempIcon;

		// Token: 0x04006DA1 RID: 28065
		private static readonly IntPtr NativeFieldInfoPtr_isDraggingCash;

		// Token: 0x04006DA2 RID: 28066
		private static readonly IntPtr NativeFieldInfoPtr_draggedCashAmount;

		// Token: 0x04006DA3 RID: 28067
		private static readonly IntPtr NativeFieldInfoPtr_PrimarySlots;

		// Token: 0x04006DA4 RID: 28068
		private static readonly IntPtr NativeFieldInfoPtr_SecondarySlots;

		// Token: 0x04006DA5 RID: 28069
		private static readonly IntPtr NativeFieldInfoPtr_customDragAmount;

		// Token: 0x04006DA6 RID: 28070
		private static readonly IntPtr NativeFieldInfoPtr_quantityChangePopRoutine;

		// Token: 0x04006DA7 RID: 28071
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04006DA8 RID: 28072
		private static readonly IntPtr NativeFieldInfoPtr_onItemMoved;

		// Token: 0x04006DA9 RID: 28073
		private static readonly IntPtr NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0;

		// Token: 0x04006DAA RID: 28074
		private static readonly IntPtr NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006DAB RID: 28075
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0;

		// Token: 0x04006DAC RID: 28076
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0;

		// Token: 0x04006DAD RID: 28077
		private static readonly IntPtr NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0;

		// Token: 0x04006DAE RID: 28078
		private static readonly IntPtr NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006DAF RID: 28079
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006DB0 RID: 28080
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006DB1 RID: 28081
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006DB2 RID: 28082
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0;

		// Token: 0x04006DB3 RID: 28083
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0;

		// Token: 0x04006DB4 RID: 28084
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0;

		// Token: 0x04006DB5 RID: 28085
		private static readonly IntPtr NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0;

		// Token: 0x04006DB6 RID: 28086
		private static readonly IntPtr NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0;

		// Token: 0x04006DB7 RID: 28087
		private static readonly IntPtr NativeMethodInfoPtr_DisableQuickMove_Public_Void_0;

		// Token: 0x04006DB8 RID: 28088
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0;

		// Token: 0x04006DB9 RID: 28089
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0;

		// Token: 0x04006DBA RID: 28090
		private static readonly IntPtr NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0;

		// Token: 0x04006DBB RID: 28091
		private static readonly IntPtr NativeMethodInfoPtr_StartDragCash_Private_Void_0;

		// Token: 0x04006DBC RID: 28092
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Private_Void_0;

		// Token: 0x04006DBD RID: 28093
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0;

		// Token: 0x04006DBE RID: 28094
		private static readonly IntPtr NativeMethodInfoPtr_EndCashDrag_Private_Void_0;

		// Token: 0x04006DBF RID: 28095
		private static readonly IntPtr NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04006DC0 RID: 28096
		private static readonly IntPtr NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04006DC1 RID: 28097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC0 RID: 3008
		[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD8C RID: 56716 RVA: 0x00345040 File Offset: 0x00343240
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr);
				ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_quantityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, "quantityText");
				ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, "<>4__this");
				ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, 100683302);
				ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, 100683303);
			}

			// Token: 0x0600DD8D RID: 56717 RVA: 0x003450BC File Offset: 0x003432BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD8E RID: 56718 RVA: 0x003450F8 File Offset: 0x003432F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285723, XrefRangeEnd = 285728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD8F RID: 56719 RVA: 0x0006BF56 File Offset: 0x0006A156
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A5 RID: 17573
			// (get) Token: 0x0600DD90 RID: 56720 RVA: 0x00345138 File Offset: 0x00343338
			// (set) Token: 0x0600DD91 RID: 56721 RVA: 0x0006BF5F File Offset: 0x0006A15F
			public unsafe TextMeshProUGUI quantityText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_quantityText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_quantityText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A6 RID: 17574
			// (get) Token: 0x0600DD92 RID: 56722 RVA: 0x00345168 File Offset: 0x00343368
			// (set) Token: 0x0600DD93 RID: 56723 RVA: 0x0006BF7E File Offset: 0x0006A17E
			public unsafe ItemUIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009469 RID: 37993
			private static readonly IntPtr NativeFieldInfoPtr_quantityText;

			// Token: 0x0400946A RID: 37994
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400946B RID: 37995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400946C RID: 37996
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C83 RID: 3203
			[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass49_0+<<SetDraggedAmount>g__LerpQuantityTextSize|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6A8 RID: 59048 RVA: 0x0035F588 File Offset: 0x0035D788
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
				{
					Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, "<<SetDraggedAmount>g__LerpQuantityTextSize|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<quantityTransform>5__2");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683304);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683305);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683306);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683307);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683308);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683309);
				}

				// Token: 0x0600E6A9 RID: 59049 RVA: 0x0035F67C File Offset: 0x0035D87C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6AA RID: 59050 RVA: 0x0035F6C4 File Offset: 0x0035D8C4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6AB RID: 59051 RVA: 0x0035F6F8 File Offset: 0x0035D8F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285702, XrefRangeEnd = 285718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047D9 RID: 18393
				// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x0035F734 File Offset: 0x0035D934
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6AD RID: 59053 RVA: 0x0035F774 File Offset: 0x0035D974
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285718, XrefRangeEnd = 285723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047DA RID: 18394
				// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0035F7A8 File Offset: 0x0035D9A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6AF RID: 59055 RVA: 0x000709CE File Offset: 0x0006EBCE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047D5 RID: 18389
				// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x0035F7E8 File Offset: 0x0035D9E8
				// (set) Token: 0x0600E6B1 RID: 59057 RVA: 0x000709D7 File Offset: 0x0006EBD7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047D6 RID: 18390
				// (get) Token: 0x0600E6B2 RID: 59058 RVA: 0x0035F810 File Offset: 0x0035DA10
				// (set) Token: 0x0600E6B3 RID: 59059 RVA: 0x000709F2 File Offset: 0x0006EBF2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D7 RID: 18391
				// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x0035F840 File Offset: 0x0035DA40
				// (set) Token: 0x0600E6B5 RID: 59061 RVA: 0x00070A11 File Offset: 0x0006EC11
				public unsafe ItemUIManager.__c__DisplayClass49_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager.__c__DisplayClass49_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D8 RID: 18392
				// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x0035F870 File Offset: 0x0035DA70
				// (set) Token: 0x0600E6B7 RID: 59063 RVA: 0x00070A30 File Offset: 0x0006EC30
				public unsafe RectTransform _quantityTransform_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A24 RID: 39460
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A25 RID: 39461
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A26 RID: 39462
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A27 RID: 39463
				private static readonly IntPtr NativeFieldInfoPtr__quantityTransform_5__2;

				// Token: 0x04009A28 RID: 39464
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A29 RID: 39465
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A2A RID: 39466
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A2B RID: 39467
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A2C RID: 39468
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A2D RID: 39469
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
