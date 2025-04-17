using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C6 RID: 1734
	public class NPCFieldUI : MonoBehaviour
	{
		// Token: 0x06009BAF RID: 39855 RVA: 0x002779F4 File Offset: 0x00275BF4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldUI()
		{
			Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr);
			NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NPCFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "FieldLabel");
			NPCFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "IconImg");
			NPCFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "SelectionLabel");
			NPCFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "NoneSelected");
			NPCFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "MultipleSelected");
			NPCFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "ClearButton");
			NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682420);
			NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682421);
			NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682422);
			NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682423);
			NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682424);
			NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682425);
			NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682426);
			NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682427);
			NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682428);
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x06009BB0 RID: 39856 RVA: 0x00277B64 File Offset: 0x00275D64
		// (set) Token: 0x06009BB1 RID: 39857 RVA: 0x00277BA4 File Offset: 0x00275DA4
		public unsafe List<NPCField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x00277BE8 File Offset: 0x00275DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276271, XrefRangeEnd = 276298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NPCField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x00277C2C File Offset: 0x00275E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276344, RefRangeEnd = 276345, XrefRangeStart = 276298, XrefRangeEnd = 276344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(NPC newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x00277C70 File Offset: 0x00275E70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276356, RefRangeEnd = 276358, XrefRangeStart = 276345, XrefRangeEnd = 276356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x00277CAC File Offset: 0x00275EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276358, XrefRangeEnd = 276375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x00277CE0 File Offset: 0x00275EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276397, RefRangeEnd = 276398, XrefRangeStart = 276375, XrefRangeEnd = 276397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x00277D24 File Offset: 0x00275F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276398, XrefRangeEnd = 276399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x00277D58 File Offset: 0x00275F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276399, XrefRangeEnd = 276407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x0004C44A File Offset: 0x0004A64A
		public NPCFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x06009BBA RID: 39866 RVA: 0x00277D94 File Offset: 0x00275F94
		// (set) Token: 0x06009BBB RID: 39867 RVA: 0x0004C453 File Offset: 0x0004A653
		public unsafe List<NPCField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x06009BBC RID: 39868 RVA: 0x00277DC4 File Offset: 0x00275FC4
		// (set) Token: 0x06009BBD RID: 39869 RVA: 0x0004C472 File Offset: 0x0004A672
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x06009BBE RID: 39870 RVA: 0x00277DF4 File Offset: 0x00275FF4
		// (set) Token: 0x06009BBF RID: 39871 RVA: 0x0004C491 File Offset: 0x0004A691
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x00277E24 File Offset: 0x00276024
		// (set) Token: 0x06009BC1 RID: 39873 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x00277E54 File Offset: 0x00276054
		// (set) Token: 0x06009BC3 RID: 39875 RVA: 0x0004C4CF File Offset: 0x0004A6CF
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x00277E84 File Offset: 0x00276084
		// (set) Token: 0x06009BC5 RID: 39877 RVA: 0x0004C4EE File Offset: 0x0004A6EE
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x00277EB4 File Offset: 0x002760B4
		// (set) Token: 0x06009BC7 RID: 39879 RVA: 0x0004C50D File Offset: 0x0004A70D
		public unsafe RectTransform ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006899 RID: 26777
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400689A RID: 26778
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x0400689B RID: 26779
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x0400689C RID: 26780
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x0400689D RID: 26781
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x0400689E RID: 26782
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x0400689F RID: 26783
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x040068A0 RID: 26784
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0;

		// Token: 0x040068A1 RID: 26785
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0;

		// Token: 0x040068A2 RID: 26786
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0;

		// Token: 0x040068A3 RID: 26787
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_NPC_0;

		// Token: 0x040068A4 RID: 26788
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068A5 RID: 26789
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040068A6 RID: 26790
		private static readonly IntPtr NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0;

		// Token: 0x040068A7 RID: 26791
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x040068A8 RID: 26792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8B RID: 2955
		[ObfuscatedName("ScheduleOne.UI.Management.NPCFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DBCE RID: 56270 RVA: 0x00340110 File Offset: 0x0033E310
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr);
				NPCFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9");
				NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100682430);
				NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100682431);
			}

			// Token: 0x0600DBCF RID: 56271 RVA: 0x0034018C File Offset: 0x0033E38C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBD0 RID: 56272 RVA: 0x003401C8 File Offset: 0x0033E3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276266, XrefRangeEnd = 276271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Refresh_b__11_0(NPCField x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBD1 RID: 56273 RVA: 0x0006B178 File Offset: 0x00069378
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004428 RID: 17448
			// (get) Token: 0x0600DBD2 RID: 56274 RVA: 0x00340218 File Offset: 0x0033E418
			// (set) Token: 0x0600DBD3 RID: 56275 RVA: 0x0006B181 File Offset: 0x00069381
			public unsafe static NPCFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004429 RID: 17449
			// (get) Token: 0x0600DBD4 RID: 56276 RVA: 0x00340240 File Offset: 0x0033E440
			// (set) Token: 0x0600DBD5 RID: 56277 RVA: 0x0006B193 File Offset: 0x00069393
			public unsafe static Func<NPCField, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCField, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009361 RID: 37729
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009362 RID: 37730
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009363 RID: 37731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009364 RID: 37732
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0;
		}
	}
}
