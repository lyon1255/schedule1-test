using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000717 RID: 1815
	public class ItemInfoPanel : MonoBehaviour
	{
		// Token: 0x0600A329 RID: 41769 RVA: 0x0028F440 File Offset: 0x0028D640
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoPanel()
		{
			Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr);
			ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "VERTICAL_THRESHOLD");
			ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<IsOpen>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<CurrentItem>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Container");
			ItemInfoPanel.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "ContentContainer");
			ItemInfoPanel.NativeFieldInfoPtr_TopArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "TopArrow");
			ItemInfoPanel.NativeFieldInfoPtr_BottomArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "BottomArrow");
			ItemInfoPanel.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Canvas");
			ItemInfoPanel.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Offset");
			ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "DefaultContentPrefab");
			ItemInfoPanel.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "content");
			ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683261);
			ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683262);
			ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683263);
			ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683264);
			ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683265);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683266);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683267);
			ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683268);
			ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683269);
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600A32A RID: 41770 RVA: 0x0028F600 File Offset: 0x0028D800
		// (set) Token: 0x0600A32B RID: 41771 RVA: 0x0028F63C File Offset: 0x0028D83C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600A32C RID: 41772 RVA: 0x0028F67C File Offset: 0x0028D87C
		// (set) Token: 0x0600A32D RID: 41773 RVA: 0x0028F6BC File Offset: 0x0028D8BC
		public unsafe ItemInstance CurrentItem
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x0028F700 File Offset: 0x0028D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285532, XrefRangeEnd = 285533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x0028F734 File Offset: 0x0028D934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285571, RefRangeEnd = 285572, XrefRangeStart = 285533, XrefRangeEnd = 285571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemInstance item, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x0028F788 File Offset: 0x0028D988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285605, RefRangeEnd = 285606, XrefRangeStart = 285572, XrefRangeEnd = 285605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition def, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x0028F7DC File Offset: 0x0028D9DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285618, RefRangeEnd = 285623, XrefRangeStart = 285606, XrefRangeEnd = 285618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0028F810 File Offset: 0x0028DA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285623, XrefRangeEnd = 285624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x00050505 File Offset: 0x0004E705
		public ItemInfoPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x0028F84C File Offset: 0x0028DA4C
		// (set) Token: 0x0600A335 RID: 41781 RVA: 0x0005050E File Offset: 0x0004E70E
		public unsafe static float VERTICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A336 RID: 41782 RVA: 0x0028F868 File Offset: 0x0028DA68
		// (set) Token: 0x0600A337 RID: 41783 RVA: 0x0005051C File Offset: 0x0004E71C
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600A338 RID: 41784 RVA: 0x0028F890 File Offset: 0x0028DA90
		// (set) Token: 0x0600A339 RID: 41785 RVA: 0x00050537 File Offset: 0x0004E737
		public unsafe ItemInstance _CurrentItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600A33A RID: 41786 RVA: 0x0028F8C0 File Offset: 0x0028DAC0
		// (set) Token: 0x0600A33B RID: 41787 RVA: 0x00050556 File Offset: 0x0004E756
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600A33C RID: 41788 RVA: 0x0028F8F0 File Offset: 0x0028DAF0
		// (set) Token: 0x0600A33D RID: 41789 RVA: 0x00050575 File Offset: 0x0004E775
		public unsafe RectTransform ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x0028F920 File Offset: 0x0028DB20
		// (set) Token: 0x0600A33F RID: 41791 RVA: 0x00050594 File Offset: 0x0004E794
		public unsafe GameObject TopArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600A340 RID: 41792 RVA: 0x0028F950 File Offset: 0x0028DB50
		// (set) Token: 0x0600A341 RID: 41793 RVA: 0x000505B3 File Offset: 0x0004E7B3
		public unsafe GameObject BottomArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600A342 RID: 41794 RVA: 0x0028F980 File Offset: 0x0028DB80
		// (set) Token: 0x0600A343 RID: 41795 RVA: 0x000505D2 File Offset: 0x0004E7D2
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x0028F9B0 File Offset: 0x0028DBB0
		// (set) Token: 0x0600A345 RID: 41797 RVA: 0x000505F1 File Offset: 0x0004E7F1
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600A346 RID: 41798 RVA: 0x0028F9D8 File Offset: 0x0028DBD8
		// (set) Token: 0x0600A347 RID: 41799 RVA: 0x0005060C File Offset: 0x0004E80C
		public unsafe ItemInfoContent DefaultContentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600A348 RID: 41800 RVA: 0x0028FA08 File Offset: 0x0028DC08
		// (set) Token: 0x0600A349 RID: 41801 RVA: 0x0005062B File Offset: 0x0004E82B
		public unsafe ItemInfoContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D6E RID: 28014
		private static readonly IntPtr NativeFieldInfoPtr_VERTICAL_THRESHOLD;

		// Token: 0x04006D6F RID: 28015
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006D70 RID: 28016
		private static readonly IntPtr NativeFieldInfoPtr__CurrentItem_k__BackingField;

		// Token: 0x04006D71 RID: 28017
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006D72 RID: 28018
		private static readonly IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x04006D73 RID: 28019
		private static readonly IntPtr NativeFieldInfoPtr_TopArrow;

		// Token: 0x04006D74 RID: 28020
		private static readonly IntPtr NativeFieldInfoPtr_BottomArrow;

		// Token: 0x04006D75 RID: 28021
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006D76 RID: 28022
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04006D77 RID: 28023
		private static readonly IntPtr NativeFieldInfoPtr_DefaultContentPrefab;

		// Token: 0x04006D78 RID: 28024
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04006D79 RID: 28025
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006D7A RID: 28026
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006D7B RID: 28027
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0;

		// Token: 0x04006D7C RID: 28028
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0;

		// Token: 0x04006D7D RID: 28029
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006D7E RID: 28030
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0;

		// Token: 0x04006D7F RID: 28031
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0;

		// Token: 0x04006D80 RID: 28032
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006D81 RID: 28033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
