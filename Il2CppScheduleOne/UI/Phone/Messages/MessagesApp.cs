using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B1 RID: 1713
	public class MessagesApp : App<MessagesApp>
	{
		// Token: 0x06009A11 RID: 39441 RVA: 0x002730E4 File Offset: 0x002712E4
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesApp()
		{
			Il2CppClassPointerStore<MessagesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessagesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr);
			MessagesApp.NativeFieldInfoPtr_Conversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "Conversations");
			MessagesApp.NativeFieldInfoPtr_ActiveConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ActiveConversations");
			MessagesApp.NativeFieldInfoPtr_categoryInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "categoryInfos");
			MessagesApp.NativeFieldInfoPtr_conversationEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryContainer");
			MessagesApp.NativeFieldInfoPtr_conversationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainer");
			MessagesApp.NativeFieldInfoPtr_homePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "homePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePageNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePageNameText");
			MessagesApp.NativeFieldInfoPtr_relationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipContainer");
			MessagesApp.NativeFieldInfoPtr_relationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipScrollbar");
			MessagesApp.NativeFieldInfoPtr_relationshipTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipTooltip");
			MessagesApp.NativeFieldInfoPtr_standardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsContainer");
			MessagesApp.NativeFieldInfoPtr_standardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsStar");
			MessagesApp.NativeFieldInfoPtr_standardsTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsTooltip");
			MessagesApp.NativeFieldInfoPtr_iconContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconContainerRect");
			MessagesApp.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconImage");
			MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "BlankAvatarSprite");
			MessagesApp.NativeFieldInfoPtr_DealWindowSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "DealWindowSelector");
			MessagesApp.NativeFieldInfoPtr_PhoneShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "PhoneShopInterface");
			MessagesApp.NativeFieldInfoPtr_CounterofferInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CounterofferInterface");
			MessagesApp.NativeFieldInfoPtr_ClearFilterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ClearFilterButton");
			MessagesApp.NativeFieldInfoPtr_CategoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryButtons");
			MessagesApp.NativeFieldInfoPtr_MessageReceivedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageReceivedSound");
			MessagesApp.NativeFieldInfoPtr_MessageSentSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageSentSound");
			MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryPrefab");
			MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainerPrefab");
			MessagesApp.NativeFieldInfoPtr_messageBubblePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "messageBubblePrefab");
			MessagesApp.NativeFieldInfoPtr_unreadConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "unreadConversations");
			MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<currentConversation>k__BackingField");
			MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682266);
			MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682267);
			MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682268);
			MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682269);
			MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682270);
			MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682271);
			MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682272);
			MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682273);
			MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682274);
			MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682275);
			MessagesApp.NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682276);
			MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682277);
			MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682278);
			MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682279);
			MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682280);
			MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682281);
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x06009A12 RID: 39442 RVA: 0x00273498 File Offset: 0x00271698
		// (set) Token: 0x06009A13 RID: 39443 RVA: 0x002734D8 File Offset: 0x002716D8
		public unsafe MSGConversation currentConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x0027351C File Offset: 0x0027171C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274112, XrefRangeEnd = 274154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x00273558 File Offset: 0x00271758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274154, XrefRangeEnd = 274174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x00273594 File Offset: 0x00271794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274174, XrefRangeEnd = 274205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x002735C8 File Offset: 0x002717C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274205, XrefRangeEnd = 274213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x002735FC File Offset: 0x002717FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274301, RefRangeEnd = 274302, XrefRangeStart = 274213, XrefRangeEnd = 274301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			entry = ((intPtr5 == 0) ? null : new RectTransform(intPtr5));
			IntPtr intPtr6 = intPtr2;
			container = ((intPtr6 == 0) ? null : new RectTransform(intPtr6));
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x00273684 File Offset: 0x00271884
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274323, RefRangeEnd = 274326, XrefRangeStart = 274302, XrefRangeEnd = 274323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x002736B8 File Offset: 0x002718B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274326, XrefRangeEnd = 274327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x002736EC File Offset: 0x002718EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274338, RefRangeEnd = 274339, XrefRangeStart = 274327, XrefRangeEnd = 274338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x00273720 File Offset: 0x00271920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274339, XrefRangeEnd = 274345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A1D RID: 39453 RVA: 0x00273770 File Offset: 0x00271970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274347, RefRangeEnd = 274348, XrefRangeStart = 274345, XrefRangeEnd = 274347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentConversation(MSGConversation conversation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x002737B4 File Offset: 0x002719B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274348, XrefRangeEnd = 274362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessagesApp.CategoryInfo>(intPtr3) : null;
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x00273800 File Offset: 0x00271A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274362, XrefRangeEnd = 274387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterByCategory(int category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A20 RID: 39456 RVA: 0x00273840 File Offset: 0x00271A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274387, XrefRangeEnd = 274406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A21 RID: 39457 RVA: 0x00273874 File Offset: 0x00271A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274406, XrefRangeEnd = 274419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A22 RID: 39458 RVA: 0x0004B3C3 File Offset: 0x000495C3
		public MessagesApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x002738B0 File Offset: 0x00271AB0
		// (set) Token: 0x06009A24 RID: 39460 RVA: 0x0004B3CC File Offset: 0x000495CC
		public unsafe static List<MSGConversation> Conversations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_Conversations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_Conversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x002738D8 File Offset: 0x00271AD8
		// (set) Token: 0x06009A26 RID: 39462 RVA: 0x0004B3DE File Offset: 0x000495DE
		public unsafe static List<MSGConversation> ActiveConversations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x00273900 File Offset: 0x00271B00
		// (set) Token: 0x06009A28 RID: 39464 RVA: 0x0004B3F0 File Offset: 0x000495F0
		public unsafe List<MessagesApp.CategoryInfo> categoryInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessagesApp.CategoryInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x06009A29 RID: 39465 RVA: 0x00273930 File Offset: 0x00271B30
		// (set) Token: 0x06009A2A RID: 39466 RVA: 0x0004B40F File Offset: 0x0004960F
		public unsafe RectTransform conversationEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x06009A2B RID: 39467 RVA: 0x00273960 File Offset: 0x00271B60
		// (set) Token: 0x06009A2C RID: 39468 RVA: 0x0004B42E File Offset: 0x0004962E
		public unsafe RectTransform conversationContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x06009A2D RID: 39469 RVA: 0x00273990 File Offset: 0x00271B90
		// (set) Token: 0x06009A2E RID: 39470 RVA: 0x0004B44D File Offset: 0x0004964D
		public unsafe GameObject homePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x06009A2F RID: 39471 RVA: 0x002739C0 File Offset: 0x00271BC0
		// (set) Token: 0x06009A30 RID: 39472 RVA: 0x0004B46C File Offset: 0x0004966C
		public unsafe GameObject dialoguePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x06009A31 RID: 39473 RVA: 0x002739F0 File Offset: 0x00271BF0
		// (set) Token: 0x06009A32 RID: 39474 RVA: 0x0004B48B File Offset: 0x0004968B
		public unsafe Text dialoguePageNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x00273A20 File Offset: 0x00271C20
		// (set) Token: 0x06009A34 RID: 39476 RVA: 0x0004B4AA File Offset: 0x000496AA
		public unsafe RectTransform relationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x00273A50 File Offset: 0x00271C50
		// (set) Token: 0x06009A36 RID: 39478 RVA: 0x0004B4C9 File Offset: 0x000496C9
		public unsafe Scrollbar relationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x06009A37 RID: 39479 RVA: 0x00273A80 File Offset: 0x00271C80
		// (set) Token: 0x06009A38 RID: 39480 RVA: 0x0004B4E8 File Offset: 0x000496E8
		public unsafe Tooltip relationshipTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x00273AB0 File Offset: 0x00271CB0
		// (set) Token: 0x06009A3A RID: 39482 RVA: 0x0004B507 File Offset: 0x00049707
		public unsafe RectTransform standardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x06009A3B RID: 39483 RVA: 0x00273AE0 File Offset: 0x00271CE0
		// (set) Token: 0x06009A3C RID: 39484 RVA: 0x0004B526 File Offset: 0x00049726
		public unsafe Image standardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x00273B10 File Offset: 0x00271D10
		// (set) Token: 0x06009A3E RID: 39486 RVA: 0x0004B545 File Offset: 0x00049745
		public unsafe Tooltip standardsTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x00273B40 File Offset: 0x00271D40
		// (set) Token: 0x06009A40 RID: 39488 RVA: 0x0004B564 File Offset: 0x00049764
		public unsafe RectTransform iconContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x06009A41 RID: 39489 RVA: 0x00273B70 File Offset: 0x00271D70
		// (set) Token: 0x06009A42 RID: 39490 RVA: 0x0004B583 File Offset: 0x00049783
		public unsafe Image iconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x00273BA0 File Offset: 0x00271DA0
		// (set) Token: 0x06009A44 RID: 39492 RVA: 0x0004B5A2 File Offset: 0x000497A2
		public unsafe Sprite BlankAvatarSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x00273BD0 File Offset: 0x00271DD0
		// (set) Token: 0x06009A46 RID: 39494 RVA: 0x0004B5C1 File Offset: 0x000497C1
		public unsafe DealWindowSelector DealWindowSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x00273C00 File Offset: 0x00271E00
		// (set) Token: 0x06009A48 RID: 39496 RVA: 0x0004B5E0 File Offset: 0x000497E0
		public unsafe PhoneShopInterface PhoneShopInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x00273C30 File Offset: 0x00271E30
		// (set) Token: 0x06009A4A RID: 39498 RVA: 0x0004B5FF File Offset: 0x000497FF
		public unsafe CounterofferInterface CounterofferInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterofferInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x06009A4B RID: 39499 RVA: 0x00273C60 File Offset: 0x00271E60
		// (set) Token: 0x06009A4C RID: 39500 RVA: 0x0004B61E File Offset: 0x0004981E
		public unsafe RectTransform ClearFilterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x06009A4D RID: 39501 RVA: 0x00273C90 File Offset: 0x00271E90
		// (set) Token: 0x06009A4E RID: 39502 RVA: 0x0004B63D File Offset: 0x0004983D
		public unsafe Il2CppReferenceArray<Button> CategoryButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x06009A4F RID: 39503 RVA: 0x00273CC0 File Offset: 0x00271EC0
		// (set) Token: 0x06009A50 RID: 39504 RVA: 0x0004B65C File Offset: 0x0004985C
		public unsafe AudioSourceController MessageReceivedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x06009A51 RID: 39505 RVA: 0x00273CF0 File Offset: 0x00271EF0
		// (set) Token: 0x06009A52 RID: 39506 RVA: 0x0004B67B File Offset: 0x0004987B
		public unsafe AudioSourceController MessageSentSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x06009A53 RID: 39507 RVA: 0x00273D20 File Offset: 0x00271F20
		// (set) Token: 0x06009A54 RID: 39508 RVA: 0x0004B69A File Offset: 0x0004989A
		public unsafe GameObject conversationEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x06009A55 RID: 39509 RVA: 0x00273D50 File Offset: 0x00271F50
		// (set) Token: 0x06009A56 RID: 39510 RVA: 0x0004B6B9 File Offset: 0x000498B9
		public unsafe GameObject conversationContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x00273D80 File Offset: 0x00271F80
		// (set) Token: 0x06009A58 RID: 39512 RVA: 0x0004B6D8 File Offset: 0x000498D8
		public unsafe GameObject messageBubblePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x00273DB0 File Offset: 0x00271FB0
		// (set) Token: 0x06009A5A RID: 39514 RVA: 0x0004B6F7 File Offset: 0x000498F7
		public unsafe List<MSGConversation> unreadConversations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x00273DE0 File Offset: 0x00271FE0
		// (set) Token: 0x06009A5C RID: 39516 RVA: 0x0004B716 File Offset: 0x00049916
		public unsafe MSGConversation _currentConversation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067AB RID: 26539
		private static readonly IntPtr NativeFieldInfoPtr_Conversations;

		// Token: 0x040067AC RID: 26540
		private static readonly IntPtr NativeFieldInfoPtr_ActiveConversations;

		// Token: 0x040067AD RID: 26541
		private static readonly IntPtr NativeFieldInfoPtr_categoryInfos;

		// Token: 0x040067AE RID: 26542
		private static readonly IntPtr NativeFieldInfoPtr_conversationEntryContainer;

		// Token: 0x040067AF RID: 26543
		private static readonly IntPtr NativeFieldInfoPtr_conversationContainer;

		// Token: 0x040067B0 RID: 26544
		private static readonly IntPtr NativeFieldInfoPtr_homePage;

		// Token: 0x040067B1 RID: 26545
		private static readonly IntPtr NativeFieldInfoPtr_dialoguePage;

		// Token: 0x040067B2 RID: 26546
		private static readonly IntPtr NativeFieldInfoPtr_dialoguePageNameText;

		// Token: 0x040067B3 RID: 26547
		private static readonly IntPtr NativeFieldInfoPtr_relationshipContainer;

		// Token: 0x040067B4 RID: 26548
		private static readonly IntPtr NativeFieldInfoPtr_relationshipScrollbar;

		// Token: 0x040067B5 RID: 26549
		private static readonly IntPtr NativeFieldInfoPtr_relationshipTooltip;

		// Token: 0x040067B6 RID: 26550
		private static readonly IntPtr NativeFieldInfoPtr_standardsContainer;

		// Token: 0x040067B7 RID: 26551
		private static readonly IntPtr NativeFieldInfoPtr_standardsStar;

		// Token: 0x040067B8 RID: 26552
		private static readonly IntPtr NativeFieldInfoPtr_standardsTooltip;

		// Token: 0x040067B9 RID: 26553
		private static readonly IntPtr NativeFieldInfoPtr_iconContainerRect;

		// Token: 0x040067BA RID: 26554
		private static readonly IntPtr NativeFieldInfoPtr_iconImage;

		// Token: 0x040067BB RID: 26555
		private static readonly IntPtr NativeFieldInfoPtr_BlankAvatarSprite;

		// Token: 0x040067BC RID: 26556
		private static readonly IntPtr NativeFieldInfoPtr_DealWindowSelector;

		// Token: 0x040067BD RID: 26557
		private static readonly IntPtr NativeFieldInfoPtr_PhoneShopInterface;

		// Token: 0x040067BE RID: 26558
		private static readonly IntPtr NativeFieldInfoPtr_CounterofferInterface;

		// Token: 0x040067BF RID: 26559
		private static readonly IntPtr NativeFieldInfoPtr_ClearFilterButton;

		// Token: 0x040067C0 RID: 26560
		private static readonly IntPtr NativeFieldInfoPtr_CategoryButtons;

		// Token: 0x040067C1 RID: 26561
		private static readonly IntPtr NativeFieldInfoPtr_MessageReceivedSound;

		// Token: 0x040067C2 RID: 26562
		private static readonly IntPtr NativeFieldInfoPtr_MessageSentSound;

		// Token: 0x040067C3 RID: 26563
		private static readonly IntPtr NativeFieldInfoPtr_conversationEntryPrefab;

		// Token: 0x040067C4 RID: 26564
		private static readonly IntPtr NativeFieldInfoPtr_conversationContainerPrefab;

		// Token: 0x040067C5 RID: 26565
		private static readonly IntPtr NativeFieldInfoPtr_messageBubblePrefab;

		// Token: 0x040067C6 RID: 26566
		private static readonly IntPtr NativeFieldInfoPtr_unreadConversations;

		// Token: 0x040067C7 RID: 26567
		private static readonly IntPtr NativeFieldInfoPtr__currentConversation_k__BackingField;

		// Token: 0x040067C8 RID: 26568
		private static readonly IntPtr NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0;

		// Token: 0x040067C9 RID: 26569
		private static readonly IntPtr NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0;

		// Token: 0x040067CA RID: 26570
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040067CB RID: 26571
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040067CC RID: 26572
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040067CD RID: 26573
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x040067CE RID: 26574
		private static readonly IntPtr NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0;

		// Token: 0x040067CF RID: 26575
		private static readonly IntPtr NativeMethodInfoPtr_RepositionEntries_Public_Void_0;

		// Token: 0x040067D0 RID: 26576
		private static readonly IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x040067D1 RID: 26577
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotifications_Public_Void_0;

		// Token: 0x040067D2 RID: 26578
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0;

		// Token: 0x040067D3 RID: 26579
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0;

		// Token: 0x040067D4 RID: 26580
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0;

		// Token: 0x040067D5 RID: 26581
		private static readonly IntPtr NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0;

		// Token: 0x040067D6 RID: 26582
		private static readonly IntPtr NativeMethodInfoPtr_ClearFilter_Public_Void_0;

		// Token: 0x040067D7 RID: 26583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7C RID: 2940
		[Serializable]
		public class CategoryInfo : Il2CppSystem.Object
		{
			// Token: 0x0600DB50 RID: 56144 RVA: 0x0033EC40 File Offset: 0x0033CE40
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInfo()
			{
				Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr);
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Category");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Name");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Color");
				MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, 100682283);
			}

			// Token: 0x0600DB51 RID: 56145 RVA: 0x0033ECBC File Offset: 0x0033CEBC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB52 RID: 56146 RVA: 0x0006AD1A File Offset: 0x00068F1A
			public CategoryInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004405 RID: 17413
			// (get) Token: 0x0600DB53 RID: 56147 RVA: 0x0033ECF8 File Offset: 0x0033CEF8
			// (set) Token: 0x0600DB54 RID: 56148 RVA: 0x0006AD23 File Offset: 0x00068F23
			public unsafe EConversationCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x17004406 RID: 17414
			// (get) Token: 0x0600DB55 RID: 56149 RVA: 0x0033ED20 File Offset: 0x0033CF20
			// (set) Token: 0x0600DB56 RID: 56150 RVA: 0x0006AD3E File Offset: 0x00068F3E
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004407 RID: 17415
			// (get) Token: 0x0600DB57 RID: 56151 RVA: 0x0033ED48 File Offset: 0x0033CF48
			// (set) Token: 0x0600DB58 RID: 56152 RVA: 0x0006AD5D File Offset: 0x00068F5D
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x0400931D RID: 37661
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x0400931E RID: 37662
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x0400931F RID: 37663
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009320 RID: 37664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B7D RID: 2941
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB59 RID: 56153 RVA: 0x0033ED70 File Offset: 0x0033CF70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr);
				MessagesApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9");
				MessagesApp.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9__35_0");
				MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100682285);
				MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100682286);
			}

			// Token: 0x0600DB5A RID: 56154 RVA: 0x0033EDEC File Offset: 0x0033CFEC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB5B RID: 56155 RVA: 0x0033EE28 File Offset: 0x0033D028
			[CallerCount(0)]
			public unsafe int _Loaded_b__35_0(MSGConversation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB5C RID: 56156 RVA: 0x0006AD78 File Offset: 0x00068F78
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004408 RID: 17416
			// (get) Token: 0x0600DB5D RID: 56157 RVA: 0x0033EE78 File Offset: 0x0033D078
			// (set) Token: 0x0600DB5E RID: 56158 RVA: 0x0006AD81 File Offset: 0x00068F81
			public unsafe static MessagesApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004409 RID: 17417
			// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x0033EEA0 File Offset: 0x0033D0A0
			// (set) Token: 0x0600DB60 RID: 56160 RVA: 0x0006AD93 File Offset: 0x00068F93
			public unsafe static Func<MSGConversation, int> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MSGConversation, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009321 RID: 37665
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009322 RID: 37666
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04009323 RID: 37667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009324 RID: 37668
			private static readonly IntPtr NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0;
		}

		// Token: 0x02000B7E RID: 2942
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB61 RID: 56161 RVA: 0x0033EEC8 File Offset: 0x0033D0C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr);
				MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, "category");
				MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, 100682287);
				MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, 100682288);
			}

			// Token: 0x0600DB62 RID: 56162 RVA: 0x0033EF30 File Offset: 0x0033D130
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB63 RID: 56163 RVA: 0x0033EF6C File Offset: 0x0033D16C
			[CallerCount(0)]
			public unsafe bool _GetCategoryInfo_b__0(MessagesApp.CategoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB64 RID: 56164 RVA: 0x0006ADA5 File Offset: 0x00068FA5
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440A RID: 17418
			// (get) Token: 0x0600DB65 RID: 56165 RVA: 0x0033EFBC File Offset: 0x0033D1BC
			// (set) Token: 0x0600DB66 RID: 56166 RVA: 0x0006ADAE File Offset: 0x00068FAE
			public unsafe EConversationCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x04009325 RID: 37669
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009326 RID: 37670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009327 RID: 37671
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0;
		}
	}
}
