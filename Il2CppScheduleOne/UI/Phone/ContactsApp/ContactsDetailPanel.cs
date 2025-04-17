using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020006B5 RID: 1717
	public class ContactsDetailPanel : MonoBehaviour
	{
		// Token: 0x06009ACA RID: 39626 RVA: 0x002750F8 File Offset: 0x002732F8
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsDetailPanel()
		{
			Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr);
			ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Min");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Max");
			ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "LayoutGroup");
			ContactsDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "NameLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "TypeLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "UnlockHintLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "ShowOnMapButton");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsStar");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_poi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "poi");
			ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682351);
			ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682352);
			ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682353);
			ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682354);
			ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682355);
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x06009ACB RID: 39627 RVA: 0x0027531C File Offset: 0x0027351C
		// (set) Token: 0x06009ACC RID: 39628 RVA: 0x0027535C File Offset: 0x0027355C
		public unsafe NPC SelectedNPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x002753A0 File Offset: 0x002735A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 275242, RefRangeEnd = 275248, XrefRangeStart = 275114, XrefRangeEnd = 275242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x002753E4 File Offset: 0x002735E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275248, XrefRangeEnd = 275281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOnMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00275418 File Offset: 0x00273618
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x0004BBB4 File Offset: 0x00049DB4
		public ContactsDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x06009AD1 RID: 39633 RVA: 0x00275454 File Offset: 0x00273654
		// (set) Token: 0x06009AD2 RID: 39634 RVA: 0x0004BBBD File Offset: 0x00049DBD
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x00275484 File Offset: 0x00273684
		// (set) Token: 0x06009AD4 RID: 39636 RVA: 0x0004BBDC File Offset: 0x00049DDC
		public unsafe Color DependenceColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min)) = value;
			}
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x06009AD5 RID: 39637 RVA: 0x002754AC File Offset: 0x002736AC
		// (set) Token: 0x06009AD6 RID: 39638 RVA: 0x0004BBF7 File Offset: 0x00049DF7
		public unsafe Color DependenceColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max)) = value;
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x002754D4 File Offset: 0x002736D4
		// (set) Token: 0x06009AD8 RID: 39640 RVA: 0x0004BC12 File Offset: 0x00049E12
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x06009AD9 RID: 39641 RVA: 0x00275504 File Offset: 0x00273704
		// (set) Token: 0x06009ADA RID: 39642 RVA: 0x0004BC31 File Offset: 0x00049E31
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x00275534 File Offset: 0x00273734
		// (set) Token: 0x06009ADC RID: 39644 RVA: 0x0004BC50 File Offset: 0x00049E50
		public unsafe Text TypeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x06009ADD RID: 39645 RVA: 0x00275564 File Offset: 0x00273764
		// (set) Token: 0x06009ADE RID: 39646 RVA: 0x0004BC6F File Offset: 0x00049E6F
		public unsafe Text UnlockHintLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x00275594 File Offset: 0x00273794
		// (set) Token: 0x06009AE0 RID: 39648 RVA: 0x0004BC8E File Offset: 0x00049E8E
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x002755C4 File Offset: 0x002737C4
		// (set) Token: 0x06009AE2 RID: 39650 RVA: 0x0004BCAD File Offset: 0x00049EAD
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x002755F4 File Offset: 0x002737F4
		// (set) Token: 0x06009AE4 RID: 39652 RVA: 0x0004BCCC File Offset: 0x00049ECC
		public unsafe Text RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x06009AE5 RID: 39653 RVA: 0x00275624 File Offset: 0x00273824
		// (set) Token: 0x06009AE6 RID: 39654 RVA: 0x0004BCEB File Offset: 0x00049EEB
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x06009AE7 RID: 39655 RVA: 0x00275654 File Offset: 0x00273854
		// (set) Token: 0x06009AE8 RID: 39656 RVA: 0x0004BD0A File Offset: 0x00049F0A
		public unsafe Scrollbar AddictionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x06009AE9 RID: 39657 RVA: 0x00275684 File Offset: 0x00273884
		// (set) Token: 0x06009AEA RID: 39658 RVA: 0x0004BD29 File Offset: 0x00049F29
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x002756B4 File Offset: 0x002738B4
		// (set) Token: 0x06009AEC RID: 39660 RVA: 0x0004BD48 File Offset: 0x00049F48
		public unsafe RectTransform PropertiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x06009AED RID: 39661 RVA: 0x002756E4 File Offset: 0x002738E4
		// (set) Token: 0x06009AEE RID: 39662 RVA: 0x0004BD67 File Offset: 0x00049F67
		public unsafe Text PropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x06009AEF RID: 39663 RVA: 0x00275714 File Offset: 0x00273914
		// (set) Token: 0x06009AF0 RID: 39664 RVA: 0x0004BD86 File Offset: 0x00049F86
		public unsafe Button ShowOnMapButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x00275744 File Offset: 0x00273944
		// (set) Token: 0x06009AF2 RID: 39666 RVA: 0x0004BDA5 File Offset: 0x00049FA5
		public unsafe RectTransform StandardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x06009AF3 RID: 39667 RVA: 0x00275774 File Offset: 0x00273974
		// (set) Token: 0x06009AF4 RID: 39668 RVA: 0x0004BDC4 File Offset: 0x00049FC4
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x06009AF5 RID: 39669 RVA: 0x002757A4 File Offset: 0x002739A4
		// (set) Token: 0x06009AF6 RID: 39670 RVA: 0x0004BDE3 File Offset: 0x00049FE3
		public unsafe Text StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x002757D4 File Offset: 0x002739D4
		// (set) Token: 0x06009AF8 RID: 39672 RVA: 0x0004BE02 File Offset: 0x0004A002
		public unsafe POI poi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006819 RID: 26649
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x0400681A RID: 26650
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Min;

		// Token: 0x0400681B RID: 26651
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Max;

		// Token: 0x0400681C RID: 26652
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x0400681D RID: 26653
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400681E RID: 26654
		private static readonly IntPtr NativeFieldInfoPtr_TypeLabel;

		// Token: 0x0400681F RID: 26655
		private static readonly IntPtr NativeFieldInfoPtr_UnlockHintLabel;

		// Token: 0x04006820 RID: 26656
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x04006821 RID: 26657
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x04006822 RID: 26658
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x04006823 RID: 26659
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x04006824 RID: 26660
		private static readonly IntPtr NativeFieldInfoPtr_AddictionScrollbar;

		// Token: 0x04006825 RID: 26661
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x04006826 RID: 26662
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesContainer;

		// Token: 0x04006827 RID: 26663
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x04006828 RID: 26664
		private static readonly IntPtr NativeFieldInfoPtr_ShowOnMapButton;

		// Token: 0x04006829 RID: 26665
		private static readonly IntPtr NativeFieldInfoPtr_StandardsContainer;

		// Token: 0x0400682A RID: 26666
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x0400682B RID: 26667
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x0400682C RID: 26668
		private static readonly IntPtr NativeFieldInfoPtr_poi;

		// Token: 0x0400682D RID: 26669
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x0400682E RID: 26670
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x0400682F RID: 26671
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x04006830 RID: 26672
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnMap_Public_Void_0;

		// Token: 0x04006831 RID: 26673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
