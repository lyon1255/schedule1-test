using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000626 RID: 1574
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x06008AA8 RID: 35496 RVA: 0x00245340 File Offset: 0x00243540
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchScreen()
		{
			Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BodySearchScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr);
			BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MAX_SPEED_BOOST");
			BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr_SlotRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotRedColor");
			BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotHighlightRedColor");
			BodySearchScreen.NativeFieldInfoPtr_GapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "GapTime");
			BodySearchScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Canvas");
			BodySearchScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Container");
			BodySearchScreen.NativeFieldInfoPtr_MinigameController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MinigameController");
			BodySearchScreen.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotContainer");
			BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ItemSlotPrefab");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicator");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorStart");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorEnd");
			BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "IndicatorAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialContainer");
			BodySearchScreen.NativeFieldInfoPtr_ResetAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ResetAnimation");
			BodySearchScreen.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "slots");
			BodySearchScreen.NativeFieldInfoPtr_onSearchClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchClear");
			BodySearchScreen.NativeFieldInfoPtr_onSearchFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchFail");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotColor");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotHighlightColor");
			BodySearchScreen.NativeFieldInfoPtr_concealedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "concealedSlot");
			BodySearchScreen.NativeFieldInfoPtr_hoveredSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "hoveredSlot");
			BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultItemIconColors");
			BodySearchScreen.NativeFieldInfoPtr_speedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "speedBoost");
			BodySearchScreen.NativeFieldInfoPtr_searcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "searcher");
			BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680528);
			BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680529);
			BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680530);
			BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680531);
			BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680532);
			BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680533);
			BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680534);
			BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680535);
			BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680536);
			BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680537);
			BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680538);
			BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680539);
			BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680540);
			BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680541);
			BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680542);
			BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680543);
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x002456E0 File Offset: 0x002438E0
		// (set) Token: 0x06008AAA RID: 35498 RVA: 0x0024571C File Offset: 0x0024391C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x06008AAB RID: 35499 RVA: 0x0024575C File Offset: 0x0024395C
		// (set) Token: 0x06008AAC RID: 35500 RVA: 0x00245798 File Offset: 0x00243998
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x002457D8 File Offset: 0x002439D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254277, XrefRangeEnd = 254313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x00245814 File Offset: 0x00243A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254405, RefRangeEnd = 254406, XrefRangeStart = 254313, XrefRangeEnd = 254405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x00245848 File Offset: 0x00243A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254406, XrefRangeEnd = 254435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x0024587C File Offset: 0x00243A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254514, RefRangeEnd = 254515, XrefRangeStart = 254435, XrefRangeEnd = 254514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _searcher, float searchTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_searcher);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x002458CC File Offset: 0x00243ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254515, XrefRangeEnd = 254519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSlotConcealed(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x0024591C File Offset: 0x00243B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254519, XrefRangeEnd = 254523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemDetected(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00245960 File Offset: 0x00243B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254523, XrefRangeEnd = 254532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotHeld(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x002459A4 File Offset: 0x00243BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254532, XrefRangeEnd = 254537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotReleased(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x002459E8 File Offset: 0x00243BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254573, RefRangeEnd = 254575, XrefRangeStart = 254537, XrefRangeEnd = 254573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x00245A28 File Offset: 0x00243C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254575, XrefRangeEnd = 254579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x00245A5C File Offset: 0x00243C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254579, XrefRangeEnd = 254582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x00245A90 File Offset: 0x00243C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254582, XrefRangeEnd = 254592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x000424ED File Offset: 0x000406ED
		public BodySearchScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x06008ABA RID: 35514 RVA: 0x00245ACC File Offset: 0x00243CCC
		// (set) Token: 0x06008ABB RID: 35515 RVA: 0x000424F6 File Offset: 0x000406F6
		public unsafe static float MAX_SPEED_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x06008ABC RID: 35516 RVA: 0x00245AE8 File Offset: 0x00243CE8
		// (set) Token: 0x06008ABD RID: 35517 RVA: 0x00042504 File Offset: 0x00040704
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x00245B10 File Offset: 0x00243D10
		// (set) Token: 0x06008ABF RID: 35519 RVA: 0x0004251F File Offset: 0x0004071F
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x06008AC0 RID: 35520 RVA: 0x00245B38 File Offset: 0x00243D38
		// (set) Token: 0x06008AC1 RID: 35521 RVA: 0x0004253A File Offset: 0x0004073A
		public unsafe Color SlotRedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor)) = value;
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x06008AC2 RID: 35522 RVA: 0x00245B60 File Offset: 0x00243D60
		// (set) Token: 0x06008AC3 RID: 35523 RVA: 0x00042555 File Offset: 0x00040755
		public unsafe Color SlotHighlightRedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor)) = value;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x06008AC4 RID: 35524 RVA: 0x00245B88 File Offset: 0x00243D88
		// (set) Token: 0x06008AC5 RID: 35525 RVA: 0x00042570 File Offset: 0x00040770
		public unsafe float GapTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime)) = value;
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x06008AC6 RID: 35526 RVA: 0x00245BB0 File Offset: 0x00243DB0
		// (set) Token: 0x06008AC7 RID: 35527 RVA: 0x0004258B File Offset: 0x0004078B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x00245BE0 File Offset: 0x00243DE0
		// (set) Token: 0x06008AC9 RID: 35529 RVA: 0x000425AA File Offset: 0x000407AA
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x06008ACA RID: 35530 RVA: 0x00245C10 File Offset: 0x00243E10
		// (set) Token: 0x06008ACB RID: 35531 RVA: 0x000425C9 File Offset: 0x000407C9
		public unsafe RectTransform MinigameController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x06008ACC RID: 35532 RVA: 0x00245C40 File Offset: 0x00243E40
		// (set) Token: 0x06008ACD RID: 35533 RVA: 0x000425E8 File Offset: 0x000407E8
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x06008ACE RID: 35534 RVA: 0x00245C70 File Offset: 0x00243E70
		// (set) Token: 0x06008ACF RID: 35535 RVA: 0x00042607 File Offset: 0x00040807
		public unsafe ItemSlotUI ItemSlotPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x06008AD0 RID: 35536 RVA: 0x00245CA0 File Offset: 0x00243EA0
		// (set) Token: 0x06008AD1 RID: 35537 RVA: 0x00042626 File Offset: 0x00040826
		public unsafe RectTransform SearchIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x06008AD2 RID: 35538 RVA: 0x00245CD0 File Offset: 0x00243ED0
		// (set) Token: 0x06008AD3 RID: 35539 RVA: 0x00042645 File Offset: 0x00040845
		public unsafe RectTransform SearchIndicatorStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x06008AD4 RID: 35540 RVA: 0x00245D00 File Offset: 0x00243F00
		// (set) Token: 0x06008AD5 RID: 35541 RVA: 0x00042664 File Offset: 0x00040864
		public unsafe RectTransform SearchIndicatorEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x06008AD6 RID: 35542 RVA: 0x00245D30 File Offset: 0x00243F30
		// (set) Token: 0x06008AD7 RID: 35543 RVA: 0x00042683 File Offset: 0x00040883
		public unsafe Animation IndicatorAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x06008AD8 RID: 35544 RVA: 0x00245D60 File Offset: 0x00243F60
		// (set) Token: 0x06008AD9 RID: 35545 RVA: 0x000426A2 File Offset: 0x000408A2
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06008ADA RID: 35546 RVA: 0x00245D90 File Offset: 0x00243F90
		// (set) Token: 0x06008ADB RID: 35547 RVA: 0x000426C1 File Offset: 0x000408C1
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x06008ADC RID: 35548 RVA: 0x00245DC0 File Offset: 0x00243FC0
		// (set) Token: 0x06008ADD RID: 35549 RVA: 0x000426E0 File Offset: 0x000408E0
		public unsafe Animation ResetAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x06008ADE RID: 35550 RVA: 0x00245DF0 File Offset: 0x00243FF0
		// (set) Token: 0x06008ADF RID: 35551 RVA: 0x000426FF File Offset: 0x000408FF
		public unsafe List<ItemSlotUI> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x06008AE0 RID: 35552 RVA: 0x00245E20 File Offset: 0x00244020
		// (set) Token: 0x06008AE1 RID: 35553 RVA: 0x0004271E File Offset: 0x0004091E
		public unsafe UnityEvent onSearchClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x06008AE2 RID: 35554 RVA: 0x00245E50 File Offset: 0x00244050
		// (set) Token: 0x06008AE3 RID: 35555 RVA: 0x0004273D File Offset: 0x0004093D
		public unsafe UnityEvent onSearchFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06008AE4 RID: 35556 RVA: 0x00245E80 File Offset: 0x00244080
		// (set) Token: 0x06008AE5 RID: 35557 RVA: 0x0004275C File Offset: 0x0004095C
		public unsafe Color defaultSlotColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor)) = value;
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x06008AE6 RID: 35558 RVA: 0x00245EA8 File Offset: 0x002440A8
		// (set) Token: 0x06008AE7 RID: 35559 RVA: 0x00042777 File Offset: 0x00040977
		public unsafe Color defaultSlotHighlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor)) = value;
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x00245ED0 File Offset: 0x002440D0
		// (set) Token: 0x06008AE9 RID: 35561 RVA: 0x00042792 File Offset: 0x00040992
		public unsafe ItemSlotUI concealedSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x06008AEA RID: 35562 RVA: 0x00245F00 File Offset: 0x00244100
		// (set) Token: 0x06008AEB RID: 35563 RVA: 0x000427B1 File Offset: 0x000409B1
		public unsafe ItemSlotUI hoveredSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x06008AEC RID: 35564 RVA: 0x00245F30 File Offset: 0x00244130
		// (set) Token: 0x06008AED RID: 35565 RVA: 0x000427D0 File Offset: 0x000409D0
		public unsafe Il2CppStructArray<Color> defaultItemIconColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x06008AEE RID: 35566 RVA: 0x00245F60 File Offset: 0x00244160
		// (set) Token: 0x06008AEF RID: 35567 RVA: 0x000427EF File Offset: 0x000409EF
		public unsafe float speedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost)) = value;
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x00245F88 File Offset: 0x00244188
		// (set) Token: 0x06008AF1 RID: 35569 RVA: 0x0004280A File Offset: 0x00040A0A
		public unsafe NPC searcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_searcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_searcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E0F RID: 24079
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SPEED_BOOST;

		// Token: 0x04005E10 RID: 24080
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E11 RID: 24081
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04005E12 RID: 24082
		private static readonly IntPtr NativeFieldInfoPtr_SlotRedColor;

		// Token: 0x04005E13 RID: 24083
		private static readonly IntPtr NativeFieldInfoPtr_SlotHighlightRedColor;

		// Token: 0x04005E14 RID: 24084
		private static readonly IntPtr NativeFieldInfoPtr_GapTime;

		// Token: 0x04005E15 RID: 24085
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005E16 RID: 24086
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005E17 RID: 24087
		private static readonly IntPtr NativeFieldInfoPtr_MinigameController;

		// Token: 0x04005E18 RID: 24088
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04005E19 RID: 24089
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotPrefab;

		// Token: 0x04005E1A RID: 24090
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicator;

		// Token: 0x04005E1B RID: 24091
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicatorStart;

		// Token: 0x04005E1C RID: 24092
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicatorEnd;

		// Token: 0x04005E1D RID: 24093
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorAnimation;

		// Token: 0x04005E1E RID: 24094
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04005E1F RID: 24095
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04005E20 RID: 24096
		private static readonly IntPtr NativeFieldInfoPtr_ResetAnimation;

		// Token: 0x04005E21 RID: 24097
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04005E22 RID: 24098
		private static readonly IntPtr NativeFieldInfoPtr_onSearchClear;

		// Token: 0x04005E23 RID: 24099
		private static readonly IntPtr NativeFieldInfoPtr_onSearchFail;

		// Token: 0x04005E24 RID: 24100
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlotColor;

		// Token: 0x04005E25 RID: 24101
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlotHighlightColor;

		// Token: 0x04005E26 RID: 24102
		private static readonly IntPtr NativeFieldInfoPtr_concealedSlot;

		// Token: 0x04005E27 RID: 24103
		private static readonly IntPtr NativeFieldInfoPtr_hoveredSlot;

		// Token: 0x04005E28 RID: 24104
		private static readonly IntPtr NativeFieldInfoPtr_defaultItemIconColors;

		// Token: 0x04005E29 RID: 24105
		private static readonly IntPtr NativeFieldInfoPtr_speedBoost;

		// Token: 0x04005E2A RID: 24106
		private static readonly IntPtr NativeFieldInfoPtr_searcher;

		// Token: 0x04005E2B RID: 24107
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E2C RID: 24108
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E2D RID: 24109
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04005E2E RID: 24110
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E2F RID: 24111
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005E30 RID: 24112
		private static readonly IntPtr NativeMethodInfoPtr_SetupSlots_Private_Void_0;

		// Token: 0x04005E31 RID: 24113
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005E32 RID: 24114
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0;

		// Token: 0x04005E33 RID: 24115
		private static readonly IntPtr NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0;

		// Token: 0x04005E34 RID: 24116
		private static readonly IntPtr NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0;

		// Token: 0x04005E35 RID: 24117
		private static readonly IntPtr NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0;

		// Token: 0x04005E36 RID: 24118
		private static readonly IntPtr NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0;

		// Token: 0x04005E37 RID: 24119
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04005E38 RID: 24120
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04005E39 RID: 24121
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04005E3A RID: 24122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B12 RID: 2834
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6AA RID: 54954 RVA: 0x00331630 File Offset: 0x0032F830
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, "slot");
				BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680544);
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680545);
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680546);
			}

			// Token: 0x0600D6AB RID: 54955 RVA: 0x003316C0 File Offset: 0x0032F8C0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AC RID: 54956 RVA: 0x003316FC File Offset: 0x0032F8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254185, XrefRangeEnd = 254194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AD RID: 54957 RVA: 0x00331740 File Offset: 0x0032F940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254194, XrefRangeEnd = 254199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AE RID: 54958 RVA: 0x00068782 File Offset: 0x00066982
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004282 RID: 17026
			// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x00331784 File Offset: 0x0032F984
			// (set) Token: 0x0600D6B0 RID: 54960 RVA: 0x0006878B File Offset: 0x0006698B
			public unsafe ItemSlotUI slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004283 RID: 17027
			// (get) Token: 0x0600D6B1 RID: 54961 RVA: 0x003317B4 File Offset: 0x0032F9B4
			// (set) Token: 0x0600D6B2 RID: 54962 RVA: 0x000687AA File Offset: 0x000669AA
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009060 RID: 36960
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04009061 RID: 36961
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009062 RID: 36962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009063 RID: 36963
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0;

			// Token: 0x04009064 RID: 36964
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0;
		}

		// Token: 0x02000B13 RID: 2835
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6B3 RID: 54963 RVA: 0x003317E4 File Offset: 0x0032F9E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "searchTime");
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680547);
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680548);
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680549);
			}

			// Token: 0x0600D6B4 RID: 54964 RVA: 0x00331874 File Offset: 0x0032FA74
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6B5 RID: 54965 RVA: 0x003318B0 File Offset: 0x0032FAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254272, XrefRangeEnd = 254277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6B6 RID: 54966 RVA: 0x003318F0 File Offset: 0x0032FAF0
			[CallerCount(0)]
			public unsafe bool _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6B7 RID: 54967 RVA: 0x000687C9 File Offset: 0x000669C9
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004284 RID: 17028
			// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x0033192C File Offset: 0x0032FB2C
			// (set) Token: 0x0600D6B9 RID: 54969 RVA: 0x000687D2 File Offset: 0x000669D2
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004285 RID: 17029
			// (get) Token: 0x0600D6BA RID: 54970 RVA: 0x0033195C File Offset: 0x0032FB5C
			// (set) Token: 0x0600D6BB RID: 54971 RVA: 0x000687F1 File Offset: 0x000669F1
			public unsafe float searchTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime)) = value;
				}
			}

			// Token: 0x04009065 RID: 36965
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009066 RID: 36966
			private static readonly IntPtr NativeFieldInfoPtr_searchTime;

			// Token: 0x04009067 RID: 36967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009068 RID: 36968
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009069 RID: 36969
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0;

			// Token: 0x02000C6D RID: 3181
			[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass37_0+<<Open>g__Search|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4E5 RID: 58597 RVA: 0x0035A644 File Offset: 0x00358844
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "<<Open>g__Search|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perGap>5__2");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perBlock>5__3");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680550);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680551);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680552);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680553);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680554);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680555);
				}

				// Token: 0x0600E4E6 RID: 58598 RVA: 0x0035A760 File Offset: 0x00358960
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4E7 RID: 58599 RVA: 0x0035A7A8 File Offset: 0x003589A8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4E8 RID: 58600 RVA: 0x0035A7DC File Offset: 0x003589DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254199, XrefRangeEnd = 254267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004726 RID: 18214
				// (get) Token: 0x0600E4E9 RID: 58601 RVA: 0x0035A818 File Offset: 0x00358A18
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4EA RID: 58602 RVA: 0x0035A858 File Offset: 0x00358A58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254267, XrefRangeEnd = 254272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004727 RID: 18215
				// (get) Token: 0x0600E4EB RID: 58603 RVA: 0x0035A88C File Offset: 0x00358A8C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4EC RID: 58604 RVA: 0x0006F9C2 File Offset: 0x0006DBC2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004720 RID: 18208
				// (get) Token: 0x0600E4ED RID: 58605 RVA: 0x0035A8CC File Offset: 0x00358ACC
				// (set) Token: 0x0600E4EE RID: 58606 RVA: 0x0006F9CB File Offset: 0x0006DBCB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004721 RID: 18209
				// (get) Token: 0x0600E4EF RID: 58607 RVA: 0x0035A8F4 File Offset: 0x00358AF4
				// (set) Token: 0x0600E4F0 RID: 58608 RVA: 0x0006F9E6 File Offset: 0x0006DBE6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004722 RID: 18210
				// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x0035A924 File Offset: 0x00358B24
				// (set) Token: 0x0600E4F2 RID: 58610 RVA: 0x0006FA05 File Offset: 0x0006DC05
				public unsafe BodySearchScreen.__c__DisplayClass37_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004723 RID: 18211
				// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x0035A954 File Offset: 0x00358B54
				// (set) Token: 0x0600E4F4 RID: 58612 RVA: 0x0006FA24 File Offset: 0x0006DC24
				public unsafe float _perGap_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2)) = value;
					}
				}

				// Token: 0x17004724 RID: 18212
				// (get) Token: 0x0600E4F5 RID: 58613 RVA: 0x0035A97C File Offset: 0x00358B7C
				// (set) Token: 0x0600E4F6 RID: 58614 RVA: 0x0006FA3F File Offset: 0x0006DC3F
				public unsafe float _perBlock_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3)) = value;
					}
				}

				// Token: 0x17004725 RID: 18213
				// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x0035A9A4 File Offset: 0x00358BA4
				// (set) Token: 0x0600E4F8 RID: 58616 RVA: 0x0006FA5A File Offset: 0x0006DC5A
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009916 RID: 39190
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009917 RID: 39191
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009918 RID: 39192
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009919 RID: 39193
				private static readonly IntPtr NativeFieldInfoPtr__perGap_5__2;

				// Token: 0x0400991A RID: 39194
				private static readonly IntPtr NativeFieldInfoPtr__perBlock_5__3;

				// Token: 0x0400991B RID: 39195
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400991C RID: 39196
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400991D RID: 39197
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400991E RID: 39198
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400991F RID: 39199
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009920 RID: 39200
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009921 RID: 39201
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
