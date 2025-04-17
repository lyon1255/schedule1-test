using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000446 RID: 1094
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x06005F6C RID: 24428 RVA: 0x001B6394 File Offset: 0x001B4594
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueContainer()
		{
			Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr);
			DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<allowExit>k__BackingField");
			DialogueContainer.NativeFieldInfoPtr_NodeLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "NodeLinks");
			DialogueContainer.NativeFieldInfoPtr_DialogueNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "DialogueNodeData");
			DialogueContainer.NativeFieldInfoPtr_BranchNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "BranchNodeData");
			DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675471);
			DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675472);
			DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675473);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675474);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675475);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675476);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675477);
			DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675478);
			DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675479);
			DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675480);
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06005F6D RID: 24429 RVA: 0x001B64DC File Offset: 0x001B46DC
		// (set) Token: 0x06005F6E RID: 24430 RVA: 0x001B6518 File Offset: 0x001B4718
		public unsafe bool allowExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06005F6F RID: 24431 RVA: 0x001B6558 File Offset: 0x001B4758
		public unsafe bool AllowExit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 198385, RefRangeEnd = 198386, XrefRangeStart = 198379, XrefRangeEnd = 198385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x001B6594 File Offset: 0x001B4794
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 198401, RefRangeEnd = 198409, XrefRangeStart = 198386, XrefRangeEnd = 198401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x001B65E4 File Offset: 0x001B47E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198424, RefRangeEnd = 198426, XrefRangeStart = 198409, XrefRangeEnd = 198424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x001B6634 File Offset: 0x001B4834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198441, RefRangeEnd = 198443, XrefRangeStart = 198426, XrefRangeEnd = 198441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x001B6684 File Offset: 0x001B4884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198458, RefRangeEnd = 198460, XrefRangeStart = 198443, XrefRangeEnd = 198458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x001B66D4 File Offset: 0x001B48D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198460, XrefRangeEnd = 198475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr3) : null;
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x001B6724 File Offset: 0x001B4924
		[CallerCount(0)]
		public unsafe void SetAllowExit(bool allowed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x001B6764 File Offset: 0x001B4964
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198497, RefRangeEnd = 198500, XrefRangeStart = 198475, XrefRangeEnd = 198497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x0002CFF7 File Offset: 0x0002B1F7
		public DialogueContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x001B67A0 File Offset: 0x001B49A0
		// (set) Token: 0x06005F79 RID: 24441 RVA: 0x0002D000 File Offset: 0x0002B200
		public unsafe bool _allowExit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x001B67C8 File Offset: 0x001B49C8
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x0002D01B File Offset: 0x0002B21B
		public unsafe List<NodeLinkData> NodeLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x001B67F8 File Offset: 0x001B49F8
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x0002D03A File Offset: 0x0002B23A
		public unsafe List<DialogueNodeData> DialogueNodeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x001B6828 File Offset: 0x001B4A28
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x0002D059 File Offset: 0x0002B259
		public unsafe List<BranchNodeData> BranchNodeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BranchNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400413D RID: 16701
		private static readonly IntPtr NativeFieldInfoPtr__allowExit_k__BackingField;

		// Token: 0x0400413E RID: 16702
		private static readonly IntPtr NativeFieldInfoPtr_NodeLinks;

		// Token: 0x0400413F RID: 16703
		private static readonly IntPtr NativeFieldInfoPtr_DialogueNodeData;

		// Token: 0x04004140 RID: 16704
		private static readonly IntPtr NativeFieldInfoPtr_BranchNodeData;

		// Token: 0x04004141 RID: 16705
		private static readonly IntPtr NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0;

		// Token: 0x04004142 RID: 16706
		private static readonly IntPtr NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0;

		// Token: 0x04004143 RID: 16707
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0;

		// Token: 0x04004144 RID: 16708
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0;

		// Token: 0x04004145 RID: 16709
		private static readonly IntPtr NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0;

		// Token: 0x04004146 RID: 16710
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0;

		// Token: 0x04004147 RID: 16711
		private static readonly IntPtr NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0;

		// Token: 0x04004148 RID: 16712
		private static readonly IntPtr NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0;

		// Token: 0x04004149 RID: 16713
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0;

		// Token: 0x0400414A RID: 16714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A08 RID: 2568
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE7C RID: 52860 RVA: 0x0031A964 File Offset: 0x00318B64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, "branchLabel");
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100675481);
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100675482);
			}

			// Token: 0x0600CE7D RID: 52861 RVA: 0x0031A9CC File Offset: 0x00318BCC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE7E RID: 52862 RVA: 0x0031AA08 File Offset: 0x00318C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByLabel_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE7F RID: 52863 RVA: 0x000646DB File Offset: 0x000628DB
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403A RID: 16442
			// (get) Token: 0x0600CE80 RID: 52864 RVA: 0x0031AA58 File Offset: 0x00318C58
			// (set) Token: 0x0600CE81 RID: 52865 RVA: 0x000646E4 File Offset: 0x000628E4
			public unsafe string branchLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B5E RID: 35678
			private static readonly IntPtr NativeFieldInfoPtr_branchLabel;

			// Token: 0x04008B5F RID: 35679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B60 RID: 35680
			private static readonly IntPtr NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000A09 RID: 2569
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE82 RID: 52866 RVA: 0x0031AA80 File Offset: 0x00318C80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, "dialogueNodeGUID");
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100675483);
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100675484);
			}

			// Token: 0x0600CE83 RID: 52867 RVA: 0x0031AAE8 File Offset: 0x00318CE8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE84 RID: 52868 RVA: 0x0031AB24 File Offset: 0x00318D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByGUID_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE85 RID: 52869 RVA: 0x00064703 File Offset: 0x00062903
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403B RID: 16443
			// (get) Token: 0x0600CE86 RID: 52870 RVA: 0x0031AB74 File Offset: 0x00318D74
			// (set) Token: 0x0600CE87 RID: 52871 RVA: 0x0006470C File Offset: 0x0006290C
			public unsafe string dialogueNodeGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B61 RID: 35681
			private static readonly IntPtr NativeFieldInfoPtr_dialogueNodeGUID;

			// Token: 0x04008B62 RID: 35682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B63 RID: 35683
			private static readonly IntPtr NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0;
		}

		// Token: 0x02000A0A RID: 2570
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE88 RID: 52872 RVA: 0x0031AB9C File Offset: 0x00318D9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, "branchGUID");
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100675485);
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100675486);
			}

			// Token: 0x0600CE89 RID: 52873 RVA: 0x0031AC04 File Offset: 0x00318E04
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE8A RID: 52874 RVA: 0x0031AC40 File Offset: 0x00318E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByGUID_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE8B RID: 52875 RVA: 0x0006472B File Offset: 0x0006292B
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403C RID: 16444
			// (get) Token: 0x0600CE8C RID: 52876 RVA: 0x0031AC90 File Offset: 0x00318E90
			// (set) Token: 0x0600CE8D RID: 52877 RVA: 0x00064734 File Offset: 0x00062934
			public unsafe string branchGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B64 RID: 35684
			private static readonly IntPtr NativeFieldInfoPtr_branchGUID;

			// Token: 0x04008B65 RID: 35685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B66 RID: 35686
			private static readonly IntPtr NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000A0B RID: 2571
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE8E RID: 52878 RVA: 0x0031ACB8 File Offset: 0x00318EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100675487);
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100675488);
			}

			// Token: 0x0600CE8F RID: 52879 RVA: 0x0031AD20 File Offset: 0x00318F20
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE90 RID: 52880 RVA: 0x0031AD5C File Offset: 0x00318F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE91 RID: 52881 RVA: 0x00064753 File Offset: 0x00062953
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403D RID: 16445
			// (get) Token: 0x0600CE92 RID: 52882 RVA: 0x0031ADAC File Offset: 0x00318FAC
			// (set) Token: 0x0600CE93 RID: 52883 RVA: 0x0006475C File Offset: 0x0006295C
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B67 RID: 35687
			private static readonly IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04008B68 RID: 35688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B69 RID: 35689
			private static readonly IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}

		// Token: 0x02000A0C RID: 2572
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE94 RID: 52884 RVA: 0x0031ADD4 File Offset: 0x00318FD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, "dialogueNodeLabel");
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100675489);
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100675490);
			}

			// Token: 0x0600CE95 RID: 52885 RVA: 0x0031AE3C File Offset: 0x0031903C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE96 RID: 52886 RVA: 0x0031AE78 File Offset: 0x00319078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198363, XrefRangeEnd = 198379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByLabel_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE97 RID: 52887 RVA: 0x0006477B File Offset: 0x0006297B
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403E RID: 16446
			// (get) Token: 0x0600CE98 RID: 52888 RVA: 0x0031AEC8 File Offset: 0x003190C8
			// (set) Token: 0x0600CE99 RID: 52889 RVA: 0x00064784 File Offset: 0x00062984
			public unsafe string dialogueNodeLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B6A RID: 35690
			private static readonly IntPtr NativeFieldInfoPtr_dialogueNodeLabel;

			// Token: 0x04008B6B RID: 35691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B6C RID: 35692
			private static readonly IntPtr NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0;
		}
	}
}
