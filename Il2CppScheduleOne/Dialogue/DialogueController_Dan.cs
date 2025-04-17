using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042E RID: 1070
	public class DialogueController_Dan : DialogueController
	{
		// Token: 0x06005E32 RID: 24114 RVA: 0x001B1DA8 File Offset: 0x001AFFA8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Dan()
		{
			Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Dan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr);
			DialogueController_Dan.NativeFieldInfoPtr_ItemToGive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, "ItemToGive");
			DialogueController_Dan.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, 100675301);
			DialogueController_Dan.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, 100675302);
			DialogueController_Dan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, 100675303);
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x001B1E28 File Offset: 0x001B0028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196667, XrefRangeEnd = 196678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dan.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x001B1E64 File Offset: 0x001B0064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196678, XrefRangeEnd = 196691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dan.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x001B1ECC File Offset: 0x001B00CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196691, XrefRangeEnd = 196695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Dan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Dan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		public DialogueController_Dan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06005E37 RID: 24119 RVA: 0x001B1F08 File Offset: 0x001B0108
		// (set) Token: 0x06005E38 RID: 24120 RVA: 0x0002C6D9 File Offset: 0x0002A8D9
		public unsafe ItemDefinition ItemToGive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Dan.NativeFieldInfoPtr_ItemToGive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Dan.NativeFieldInfoPtr_ItemToGive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004070 RID: 16496
		private static readonly IntPtr NativeFieldInfoPtr_ItemToGive;

		// Token: 0x04004071 RID: 16497
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004072 RID: 16498
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04004073 RID: 16499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
