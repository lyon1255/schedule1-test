using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000447 RID: 1095
	[Serializable]
	public class DialogueNodeData : Il2CppSystem.Object
	{
		// Token: 0x06005F80 RID: 24448 RVA: 0x001B6858 File Offset: 0x001B4A58
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeData()
		{
			Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr);
			DialogueNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Guid");
			DialogueNodeData.NativeFieldInfoPtr_DialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueText");
			DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueNodeLabel");
			DialogueNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Position");
			DialogueNodeData.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "choices");
			DialogueNodeData.NativeFieldInfoPtr_VoiceLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "VoiceLine");
			DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100675491);
			DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100675492);
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x001B6928 File Offset: 0x001B4B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198500, XrefRangeEnd = 198509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x001B6968 File Offset: 0x001B4B68
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x0002D078 File Offset: 0x0002B278
		public DialogueNodeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x001B69A4 File Offset: 0x001B4BA4
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x0002D081 File Offset: 0x0002B281
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x001B69CC File Offset: 0x001B4BCC
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		public unsafe string DialogueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x001B69F4 File Offset: 0x001B4BF4
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x0002D0BF File Offset: 0x0002B2BF
		public unsafe string DialogueNodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x001B6A1C File Offset: 0x001B4C1C
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x0002D0DE File Offset: 0x0002B2DE
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x001B6A44 File Offset: 0x001B4C44
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x0002D0F9 File Offset: 0x0002B2F9
		public unsafe Il2CppReferenceArray<DialogueChoiceData> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x001B6A74 File Offset: 0x001B4C74
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x0002D118 File Offset: 0x0002B318
		public unsafe EVOLineType VoiceLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine)) = value;
			}
		}

		// Token: 0x0400414B RID: 16715
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x0400414C RID: 16716
		private static readonly IntPtr NativeFieldInfoPtr_DialogueText;

		// Token: 0x0400414D RID: 16717
		private static readonly IntPtr NativeFieldInfoPtr_DialogueNodeLabel;

		// Token: 0x0400414E RID: 16718
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400414F RID: 16719
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x04004150 RID: 16720
		private static readonly IntPtr NativeFieldInfoPtr_VoiceLine;

		// Token: 0x04004151 RID: 16721
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0;

		// Token: 0x04004152 RID: 16722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
