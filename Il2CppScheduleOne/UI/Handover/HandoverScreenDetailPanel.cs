using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x020006F3 RID: 1779
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		// Token: 0x06009F62 RID: 40802 RVA: 0x00283334 File Offset: 0x00281534
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenDetailPanel()
		{
			Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr);
			HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "LayoutGroup");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "Container");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "NameLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AddictionContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AdditionScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsStar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "EffectsLabel");
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100682815);
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100682816);
			HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100682817);
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x00283468 File Offset: 0x00281668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281251, XrefRangeEnd = 281316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x002834AC File Offset: 0x002816AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194676, XrefRangeEnd = 194677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x002834E0 File Offset: 0x002816E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x0004E462 File Offset: 0x0004C662
		public HandoverScreenDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06009F67 RID: 40807 RVA: 0x0028351C File Offset: 0x0028171C
		// (set) Token: 0x06009F68 RID: 40808 RVA: 0x0004E46B File Offset: 0x0004C66B
		public unsafe LayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x0028354C File Offset: 0x0028174C
		// (set) Token: 0x06009F6A RID: 40810 RVA: 0x0004E48A File Offset: 0x0004C68A
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x06009F6B RID: 40811 RVA: 0x0028357C File Offset: 0x0028177C
		// (set) Token: 0x06009F6C RID: 40812 RVA: 0x0004E4A9 File Offset: 0x0004C6A9
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x06009F6D RID: 40813 RVA: 0x002835AC File Offset: 0x002817AC
		// (set) Token: 0x06009F6E RID: 40814 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06009F6F RID: 40815 RVA: 0x002835DC File Offset: 0x002817DC
		// (set) Token: 0x06009F70 RID: 40816 RVA: 0x0004E4E7 File Offset: 0x0004C6E7
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x06009F71 RID: 40817 RVA: 0x0028360C File Offset: 0x0028180C
		// (set) Token: 0x06009F72 RID: 40818 RVA: 0x0004E506 File Offset: 0x0004C706
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x0028363C File Offset: 0x0028183C
		// (set) Token: 0x06009F74 RID: 40820 RVA: 0x0004E525 File Offset: 0x0004C725
		public unsafe Scrollbar AdditionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x06009F75 RID: 40821 RVA: 0x0028366C File Offset: 0x0028186C
		// (set) Token: 0x06009F76 RID: 40822 RVA: 0x0004E544 File Offset: 0x0004C744
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x0028369C File Offset: 0x0028189C
		// (set) Token: 0x06009F78 RID: 40824 RVA: 0x0004E563 File Offset: 0x0004C763
		public unsafe TextMeshProUGUI StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x06009F79 RID: 40825 RVA: 0x002836CC File Offset: 0x002818CC
		// (set) Token: 0x06009F7A RID: 40826 RVA: 0x0004E582 File Offset: 0x0004C782
		public unsafe TextMeshProUGUI EffectsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AEA RID: 27370
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x04006AEB RID: 27371
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006AEC RID: 27372
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006AED RID: 27373
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x04006AEE RID: 27374
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x04006AEF RID: 27375
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x04006AF0 RID: 27376
		private static readonly IntPtr NativeFieldInfoPtr_AdditionScrollbar;

		// Token: 0x04006AF1 RID: 27377
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x04006AF2 RID: 27378
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x04006AF3 RID: 27379
		private static readonly IntPtr NativeFieldInfoPtr_EffectsLabel;

		// Token: 0x04006AF4 RID: 27380
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Customer_0;

		// Token: 0x04006AF5 RID: 27381
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006AF6 RID: 27382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
