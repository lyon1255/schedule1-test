using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.Presets.Options;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Management.SetterScreens
{
	// Token: 0x020003AA RID: 938
	public class ItemSetterScreen : Singleton<ItemSetterScreen>
	{
		// Token: 0x0600494C RID: 18764 RVA: 0x001656BC File Offset: 0x001638BC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSetterScreen()
		{
			Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.SetterScreens", "ItemSetterScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr);
			ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<Option>k__BackingField");
			ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "ListEntryPrefab");
			ItemSetterScreen.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "EntryContainer");
			ItemSetterScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "TitleLabel");
			ItemSetterScreen.NativeFieldInfoPtr_allEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "allEntry");
			ItemSetterScreen.NativeFieldInfoPtr_noneEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "noneEntry");
			ItemSetterScreen.NativeFieldInfoPtr_pairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "pairs");
			ItemSetterScreen.NativeMethodInfoPtr_get_Option_Public_get_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672387);
			ItemSetterScreen.NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672388);
			ItemSetterScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672389);
			ItemSetterScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672390);
			ItemSetterScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672391);
			ItemSetterScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672392);
			ItemSetterScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672393);
			ItemSetterScreen.NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672394);
			ItemSetterScreen.NativeMethodInfoPtr_AllClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672395);
			ItemSetterScreen.NativeMethodInfoPtr_NoneClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672396);
			ItemSetterScreen.NativeMethodInfoPtr_EntryClicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672397);
			ItemSetterScreen.NativeMethodInfoPtr_RefreshTicks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672398);
			ItemSetterScreen.NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672399);
			ItemSetterScreen.NativeMethodInfoPtr_CreateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672400);
			ItemSetterScreen.NativeMethodInfoPtr_DestroyEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672401);
			ItemSetterScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672402);
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x001658B8 File Offset: 0x00163AB8
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x001658F8 File Offset: 0x00163AF8
		public unsafe ItemList Option
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_get_Option_Public_get_ItemList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x0016593C File Offset: 0x00163B3C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 163105, RefRangeEnd = 163106, XrefRangeStart = 163105, XrefRangeEnd = 163105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00165978 File Offset: 0x00163B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163106, XrefRangeEnd = 163141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x001659B4 File Offset: 0x00163BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163141, XrefRangeEnd = 163159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(ItemList option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00165A04 File Offset: 0x00163C04
		[CallerCount(0)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00165A48 File Offset: 0x00163C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163159, XrefRangeEnd = 163164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00165A84 File Offset: 0x00163C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163223, RefRangeEnd = 163225, XrefRangeStart = 163164, XrefRangeEnd = 163223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateEntry(Sprite icon, string label, Action onClick, string prefabID = "", bool createPair = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClick);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createPair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00165B1C File Offset: 0x00163D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163225, XrefRangeEnd = 163227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_AllClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00165B50 File Offset: 0x00163D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163227, XrefRangeEnd = 163231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_NoneClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00165B84 File Offset: 0x00163D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163231, XrefRangeEnd = 163248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked(string prefabID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_EntryClicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00165BC8 File Offset: 0x00163DC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163291, RefRangeEnd = 163295, XrefRangeStart = 163248, XrefRangeEnd = 163291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_RefreshTicks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00165BFC File Offset: 0x00163DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163301, RefRangeEnd = 163302, XrefRangeStart = 163295, XrefRangeEnd = 163301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryTicked(RectTransform entry, bool ticked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ticked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00165C4C File Offset: 0x00163E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163302, XrefRangeEnd = 163311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_CreateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00165C80 File Offset: 0x00163E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163332, RefRangeEnd = 163333, XrefRangeStart = 163311, XrefRangeEnd = 163332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_DestroyEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00165CB4 File Offset: 0x00163EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163333, XrefRangeEnd = 163343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSetterScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x000234FB File Offset: 0x000216FB
		public ItemSetterScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x00165CF0 File Offset: 0x00163EF0
		// (set) Token: 0x0600495F RID: 18783 RVA: 0x00023504 File Offset: 0x00021704
		public unsafe ItemList _Option_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06004960 RID: 18784 RVA: 0x00165D20 File Offset: 0x00163F20
		// (set) Token: 0x06004961 RID: 18785 RVA: 0x00023523 File Offset: 0x00021723
		public unsafe GameObject ListEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06004962 RID: 18786 RVA: 0x00165D50 File Offset: 0x00163F50
		// (set) Token: 0x06004963 RID: 18787 RVA: 0x00023542 File Offset: 0x00021742
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x00165D80 File Offset: 0x00163F80
		// (set) Token: 0x06004965 RID: 18789 RVA: 0x00023561 File Offset: 0x00021761
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x00165DB0 File Offset: 0x00163FB0
		// (set) Token: 0x06004967 RID: 18791 RVA: 0x00023580 File Offset: 0x00021780
		public unsafe RectTransform allEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_allEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_allEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x00165DE0 File Offset: 0x00163FE0
		// (set) Token: 0x06004969 RID: 18793 RVA: 0x0002359F File Offset: 0x0002179F
		public unsafe RectTransform noneEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_noneEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_noneEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x00165E10 File Offset: 0x00164010
		// (set) Token: 0x0600496B RID: 18795 RVA: 0x000235BE File Offset: 0x000217BE
		public unsafe List<ItemSetterScreen.Pair> pairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_pairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSetterScreen.Pair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_pairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeFieldInfoPtr__Option_k__BackingField;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeFieldInfoPtr_ListEntryPrefab;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeFieldInfoPtr_allEntry;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeFieldInfoPtr_noneEntry;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeFieldInfoPtr_pairs;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_get_Option_Public_get_ItemList_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_AllClicked_Private_Void_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_NoneClicked_Private_Void_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_EntryClicked_Private_Void_String_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTicks_Private_Void_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntries_Private_Void_0;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeMethodInfoPtr_DestroyEntries_Private_Void_0;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200097F RID: 2431
		public class Pair : Il2CppSystem.Object
		{
			// Token: 0x0600C9EB RID: 51691 RVA: 0x0030DA38 File Offset: 0x0030BC38
			// Note: this type is marked as 'beforefieldinit'.
			static Pair()
			{
				Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "Pair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr);
				ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, "prefabID");
				ItemSetterScreen.Pair.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, "entry");
				ItemSetterScreen.Pair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, 100672403);
			}

			// Token: 0x0600C9EC RID: 51692 RVA: 0x0030DAA0 File Offset: 0x0030BCA0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.Pair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9ED RID: 51693 RVA: 0x000622E3 File Offset: 0x000604E3
			public Pair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF1 RID: 16113
			// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x0030DADC File Offset: 0x0030BCDC
			// (set) Token: 0x0600C9EF RID: 51695 RVA: 0x000622EC File Offset: 0x000604EC
			public unsafe string prefabID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EF2 RID: 16114
			// (get) Token: 0x0600C9F0 RID: 51696 RVA: 0x0030DB04 File Offset: 0x0030BD04
			// (set) Token: 0x0600C9F1 RID: 51697 RVA: 0x0006230B File Offset: 0x0006050B
			public unsafe RectTransform entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088A0 RID: 34976
			private static readonly IntPtr NativeFieldInfoPtr_prefabID;

			// Token: 0x040088A1 RID: 34977
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040088A2 RID: 34978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000980 RID: 2432
		[ObfuscatedName("ScheduleOne.Management.SetterScreens.ItemSetterScreen+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9F2 RID: 51698 RVA: 0x0030DB34 File Offset: 0x0030BD34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr);
				ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, "onClick");
				ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, 100672404);
				ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, 100672405);
			}

			// Token: 0x0600C9F3 RID: 51699 RVA: 0x0030DB9C File Offset: 0x0030BD9C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9F4 RID: 51700 RVA: 0x0030DBD8 File Offset: 0x0030BDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9F5 RID: 51701 RVA: 0x0006232A File Offset: 0x0006052A
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF3 RID: 16115
			// (get) Token: 0x0600C9F6 RID: 51702 RVA: 0x0030DC0C File Offset: 0x0030BE0C
			// (set) Token: 0x0600C9F7 RID: 51703 RVA: 0x00062333 File Offset: 0x00060533
			public unsafe Action onClick
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088A3 RID: 34979
			private static readonly IntPtr NativeFieldInfoPtr_onClick;

			// Token: 0x040088A4 RID: 34980
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088A5 RID: 34981
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0;
		}

		// Token: 0x02000981 RID: 2433
		[ObfuscatedName("ScheduleOne.Management.SetterScreens.ItemSetterScreen+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9F8 RID: 51704 RVA: 0x0030DC3C File Offset: 0x0030BE3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr);
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "i");
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "<>9__0");
				ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, 100672406);
				ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, 100672407);
			}

			// Token: 0x0600C9F9 RID: 51705 RVA: 0x0030DCCC File Offset: 0x0030BECC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9FA RID: 51706 RVA: 0x0030DD08 File Offset: 0x0030BF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163100, XrefRangeEnd = 163105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshTicks_b__0(ItemSetterScreen.Pair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9FB RID: 51707 RVA: 0x00062352 File Offset: 0x00060552
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF4 RID: 16116
			// (get) Token: 0x0600C9FC RID: 51708 RVA: 0x0030DD58 File Offset: 0x0030BF58
			// (set) Token: 0x0600C9FD RID: 51709 RVA: 0x0006235B File Offset: 0x0006055B
			public unsafe ItemSetterScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSetterScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF5 RID: 16117
			// (get) Token: 0x0600C9FE RID: 51710 RVA: 0x0030DD88 File Offset: 0x0030BF88
			// (set) Token: 0x0600C9FF RID: 51711 RVA: 0x0006237A File Offset: 0x0006057A
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17003EF6 RID: 16118
			// (get) Token: 0x0600CA00 RID: 51712 RVA: 0x0030DDB0 File Offset: 0x0030BFB0
			// (set) Token: 0x0600CA01 RID: 51713 RVA: 0x00062395 File Offset: 0x00060595
			public unsafe Predicate<ItemSetterScreen.Pair> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemSetterScreen.Pair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088A6 RID: 34982
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088A7 RID: 34983
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040088A8 RID: 34984
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040088A9 RID: 34985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088AA RID: 34986
			private static readonly IntPtr NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0;
		}
	}
}
