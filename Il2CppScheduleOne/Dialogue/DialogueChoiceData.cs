using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000445 RID: 1093
	[Serializable]
	public class DialogueChoiceData : Object
	{
		// Token: 0x06005F63 RID: 24419 RVA: 0x001B6260 File Offset: 0x001B4460
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceData()
		{
			Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChoiceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr);
			DialogueChoiceData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "Guid");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceText");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceLabel");
			DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, 100675470);
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x001B62E0 File Offset: 0x001B44E0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x0002CF91 File Offset: 0x0002B191
		public DialogueChoiceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x001B631C File Offset: 0x001B451C
		// (set) Token: 0x06005F67 RID: 24423 RVA: 0x0002CF9A File Offset: 0x0002B19A
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x001B6344 File Offset: 0x001B4544
		// (set) Token: 0x06005F69 RID: 24425 RVA: 0x0002CFB9 File Offset: 0x0002B1B9
		public unsafe string ChoiceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001B636C File Offset: 0x001B456C
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x0002CFD8 File Offset: 0x0002B1D8
		public unsafe string ChoiceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004139 RID: 16697
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x0400413A RID: 16698
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceText;

		// Token: 0x0400413B RID: 16699
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceLabel;

		// Token: 0x0400413C RID: 16700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
