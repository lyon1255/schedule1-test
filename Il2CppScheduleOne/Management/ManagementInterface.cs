using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.UI;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A3 RID: 931
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x060048E3 RID: 18659 RVA: 0x001640DC File Offset: 0x001622DC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementInterface()
		{
			Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr);
			ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PANEL_SLIDE_TIME");
			ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<EquippedClipboard>k__BackingField");
			ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NothingSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "DifferentTypesSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_PanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PanelContainer");
			ManagementInterface.NativeFieldInfoPtr_MainScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "MainScreen");
			ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ItemSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_NPCSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NPCSelector");
			ManagementInterface.NativeFieldInfoPtr_ObjectSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ObjectSelector");
			ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "RecipeSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "TransitEntitySelector");
			ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigPanelPrefabs");
			ManagementInterface.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "Configurables");
			ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "areConfigurablesUniform");
			ManagementInterface.NativeFieldInfoPtr_loadedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "loadedPanel");
			ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672338);
			ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672339);
			ManagementInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672340);
			ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672341);
			ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672342);
			ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672343);
			ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672344);
			ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672345);
			ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672346);
			ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672347);
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x00164300 File Offset: 0x00162500
		// (set) Token: 0x060048E5 RID: 18661 RVA: 0x00164340 File Offset: 0x00162540
		public unsafe ManagementClipboard_Equippable EquippedClipboard
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x00164384 File Offset: 0x00162584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162728, XrefRangeEnd = 162731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x001643C0 File Offset: 0x001625C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162768, RefRangeEnd = 162769, XrefRangeStart = 162731, XrefRangeEnd = 162768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurables);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_equippedClipboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00164414 File Offset: 0x00162614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162782, RefRangeEnd = 162783, XrefRangeStart = 162769, XrefRangeEnd = 162782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveState = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00164454 File Offset: 0x00162654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162783, XrefRangeEnd = 162789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMainLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00164488 File Offset: 0x00162688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162850, RefRangeEnd = 162851, XrefRangeStart = 162789, XrefRangeEnd = 162850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x001644BC File Offset: 0x001626BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162860, RefRangeEnd = 162862, XrefRangeStart = 162851, XrefRangeEnd = 162860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x001644F0 File Offset: 0x001626F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162862, XrefRangeEnd = 162875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr3) : null;
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x0016453C File Offset: 0x0016273C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162875, XrefRangeEnd = 162885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x000231ED File Offset: 0x000213ED
		public ManagementInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x00164578 File Offset: 0x00162778
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x000231F6 File Offset: 0x000213F6
		public unsafe static float PANEL_SLIDE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&value));
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x00164594 File Offset: 0x00162794
		// (set) Token: 0x060048F2 RID: 18674 RVA: 0x00023204 File Offset: 0x00021404
		public unsafe ManagementClipboard_Equippable _EquippedClipboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x001645C4 File Offset: 0x001627C4
		// (set) Token: 0x060048F4 RID: 18676 RVA: 0x00023223 File Offset: 0x00021423
		public unsafe TextMeshProUGUI NothingSelectedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x001645F4 File Offset: 0x001627F4
		// (set) Token: 0x060048F6 RID: 18678 RVA: 0x00023242 File Offset: 0x00021442
		public unsafe TextMeshProUGUI DifferentTypesSelectedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x00164624 File Offset: 0x00162824
		// (set) Token: 0x060048F8 RID: 18680 RVA: 0x00023261 File Offset: 0x00021461
		public unsafe RectTransform PanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x00164654 File Offset: 0x00162854
		// (set) Token: 0x060048FA RID: 18682 RVA: 0x00023280 File Offset: 0x00021480
		public unsafe ClipboardScreen MainScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x00164684 File Offset: 0x00162884
		// (set) Token: 0x060048FC RID: 18684 RVA: 0x0002329F File Offset: 0x0002149F
		public unsafe ItemSelector ItemSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x001646B4 File Offset: 0x001628B4
		// (set) Token: 0x060048FE RID: 18686 RVA: 0x000232BE File Offset: 0x000214BE
		public unsafe NPCSelector NPCSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NPCSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NPCSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x001646E4 File Offset: 0x001628E4
		// (set) Token: 0x06004900 RID: 18688 RVA: 0x000232DD File Offset: 0x000214DD
		public unsafe Il2CppScheduleOne.UI.Management.ObjectSelector ObjectSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.UI.Management.ObjectSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x00164714 File Offset: 0x00162914
		// (set) Token: 0x06004902 RID: 18690 RVA: 0x000232FC File Offset: 0x000214FC
		public unsafe RecipeSelector RecipeSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x00164744 File Offset: 0x00162944
		// (set) Token: 0x06004904 RID: 18692 RVA: 0x0002331B File Offset: 0x0002151B
		public unsafe TransitEntitySelector TransitEntitySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06004905 RID: 18693 RVA: 0x00164774 File Offset: 0x00162974
		// (set) Token: 0x06004906 RID: 18694 RVA: 0x0002333A File Offset: 0x0002153A
		public unsafe Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel> ConfigPanelPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x001647A4 File Offset: 0x001629A4
		// (set) Token: 0x06004908 RID: 18696 RVA: 0x00023359 File Offset: 0x00021559
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x001647D4 File Offset: 0x001629D4
		// (set) Token: 0x0600490A RID: 18698 RVA: 0x00023378 File Offset: 0x00021578
		public unsafe bool areConfigurablesUniform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform)) = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x001647FC File Offset: 0x001629FC
		// (set) Token: 0x0600490C RID: 18700 RVA: 0x00023393 File Offset: 0x00021593
		public unsafe ConfigPanel loadedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeFieldInfoPtr_PANEL_SLIDE_TIME;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeFieldInfoPtr__EquippedClipboard_k__BackingField;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelectedLabel;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeFieldInfoPtr_DifferentTypesSelectedLabel;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeFieldInfoPtr_PanelContainer;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeFieldInfoPtr_MainScreen;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeFieldInfoPtr_ItemSelectorScreen;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeFieldInfoPtr_NPCSelector;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeFieldInfoPtr_ObjectSelector;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelectorScreen;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeFieldInfoPtr_TransitEntitySelector;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeFieldInfoPtr_ConfigPanelPrefabs;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeFieldInfoPtr_areConfigurablesUniform;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeFieldInfoPtr_loadedPanel;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0;

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200097B RID: 2427
		[Serializable]
		public class ConfigurableTypePanel : Il2CppSystem.Object
		{
			// Token: 0x0600C9D6 RID: 51670 RVA: 0x0030D6C8 File Offset: 0x0030B8C8
			// Note: this type is marked as 'beforefieldinit'.
			static ConfigurableTypePanel()
			{
				Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigurableTypePanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr);
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Type");
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Panel");
				ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, 100672348);
			}

			// Token: 0x0600C9D7 RID: 51671 RVA: 0x0030D730 File Offset: 0x0030B930
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfigurableTypePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9D8 RID: 51672 RVA: 0x0006224F File Offset: 0x0006044F
			public ConfigurableTypePanel(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEC RID: 16108
			// (get) Token: 0x0600C9D9 RID: 51673 RVA: 0x0030D76C File Offset: 0x0030B96C
			// (set) Token: 0x0600C9DA RID: 51674 RVA: 0x00062258 File Offset: 0x00060458
			public unsafe EConfigurableType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x17003EED RID: 16109
			// (get) Token: 0x0600C9DB RID: 51675 RVA: 0x0030D794 File Offset: 0x0030B994
			// (set) Token: 0x0600C9DC RID: 51676 RVA: 0x00062273 File Offset: 0x00060473
			public unsafe ConfigPanel Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008893 RID: 34963
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04008894 RID: 34964
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x04008895 RID: 34965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200097C RID: 2428
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C9DD RID: 51677 RVA: 0x0030D7C4 File Offset: 0x0030B9C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr);
				ManagementInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9");
				ManagementInterface.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9__23_0");
				ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100672350);
				ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100672351);
			}

			// Token: 0x0600C9DE RID: 51678 RVA: 0x0030D840 File Offset: 0x0030BA40
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9DF RID: 51679 RVA: 0x0030D87C File Offset: 0x0030BA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162724, XrefRangeEnd = 162728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityConfiguration _InitializeConfigPanel_b__23_0(IConfigurable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}

			// Token: 0x0600C9E0 RID: 51680 RVA: 0x00062292 File Offset: 0x00060492
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEE RID: 16110
			// (get) Token: 0x0600C9E1 RID: 51681 RVA: 0x0030D8CC File Offset: 0x0030BACC
			// (set) Token: 0x0600C9E2 RID: 51682 RVA: 0x0006229B File Offset: 0x0006049B
			public unsafe static ManagementInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EEF RID: 16111
			// (get) Token: 0x0600C9E3 RID: 51683 RVA: 0x0030D8F4 File Offset: 0x0030BAF4
			// (set) Token: 0x0600C9E4 RID: 51684 RVA: 0x000622AD File Offset: 0x000604AD
			public unsafe static Func<IConfigurable, EntityConfiguration> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IConfigurable, EntityConfiguration>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008896 RID: 34966
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008897 RID: 34967
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04008898 RID: 34968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008899 RID: 34969
			private static readonly IntPtr NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0;
		}

		// Token: 0x0200097D RID: 2429
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9E5 RID: 51685 RVA: 0x0030D91C File Offset: 0x0030BB1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr);
				ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, "type");
				ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, 100672352);
				ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, 100672353);
			}

			// Token: 0x0600C9E6 RID: 51686 RVA: 0x0030D984 File Offset: 0x0030BB84
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9E7 RID: 51687 RVA: 0x0030D9C0 File Offset: 0x0030BBC0
			[CallerCount(0)]
			public unsafe bool _GetConfigPanelPrefab_b__0(ManagementInterface.ConfigurableTypePanel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9E8 RID: 51688 RVA: 0x000622BF File Offset: 0x000604BF
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF0 RID: 16112
			// (get) Token: 0x0600C9E9 RID: 51689 RVA: 0x0030DA10 File Offset: 0x0030BC10
			// (set) Token: 0x0600C9EA RID: 51690 RVA: 0x000622C8 File Offset: 0x000604C8
			public unsafe EConfigurableType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x0400889A RID: 34970
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400889B RID: 34971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400889C RID: 34972
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0;
		}
	}
}
