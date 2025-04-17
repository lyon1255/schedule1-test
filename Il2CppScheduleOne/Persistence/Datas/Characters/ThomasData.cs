using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas.Characters
{
	// Token: 0x020002C0 RID: 704
	public class ThomasData : NPCData
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x0010F09C File Offset: 0x0010D29C
		// Note: this type is marked as 'beforefieldinit'.
		static ThomasData()
		{
			Il2CppClassPointerStore<ThomasData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas.Characters", "ThomasData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThomasData>.NativeClassPtr);
			ThomasData.NativeFieldInfoPtr_MeetingReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "MeetingReminderSent");
			ThomasData.NativeFieldInfoPtr_HandoverReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "HandoverReminderSent");
			ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, 100668861);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x0010F108 File Offset: 0x0010D308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131232, RefRangeEnd = 131233, XrefRangeStart = 131230, XrefRangeEnd = 131232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThomasData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meetingReminderSent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverReminderSent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x0001AD96 File Offset: 0x00018F96
		public ThomasData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0010F170 File Offset: 0x0010D370
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0001AD9F File Offset: 0x00018F9F
		public unsafe bool MeetingReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent)) = value;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x0010F198 File Offset: 0x0010D398
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x0001ADBA File Offset: 0x00018FBA
		public unsafe bool HandoverReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent)) = value;
			}
		}

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeFieldInfoPtr_MeetingReminderSent;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_HandoverReminderSent;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
	}
}
