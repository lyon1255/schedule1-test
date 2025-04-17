using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000432 RID: 1074
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x06005E6E RID: 24174 RVA: 0x001B2C48 File Offset: 0x001B0E48
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Police()
		{
			Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr);
			DialogueController_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, "officer");
			DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675330);
			DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675331);
			DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675332);
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x001B2CC8 File Offset: 0x001B0EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197094, XrefRangeEnd = 197102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x001B2D04 File Offset: 0x001B0F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197102, XrefRangeEnd = 197103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x001B2D4C File Offset: 0x001B0F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197103, XrefRangeEnd = 197107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x0002C87B File Offset: 0x0002AA7B
		public DialogueController_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x001B2D88 File Offset: 0x001B0F88
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x0002C884 File Offset: 0x0002AA84
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004097 RID: 16535
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04004098 RID: 16536
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004099 RID: 16537
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0;

		// Token: 0x0400409A RID: 16538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
