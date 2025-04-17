using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public class TextMessageData : Object
	{
		// Token: 0x060031BD RID: 12733 RVA: 0x0010E2E0 File Offset: 0x0010C4E0
		// Note: this type is marked as 'beforefieldinit'.
		static TextMessageData()
		{
			Il2CppClassPointerStore<TextMessageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextMessageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr);
			TextMessageData.NativeFieldInfoPtr_Sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Sender");
			TextMessageData.NativeFieldInfoPtr_MessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "MessageID");
			TextMessageData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Text");
			TextMessageData.NativeFieldInfoPtr_EndOfChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "EndOfChain");
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100668848);
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100668849);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0010E388 File Offset: 0x0010C588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131179, RefRangeEnd = 131181, XrefRangeStart = 131177, XrefRangeEnd = 131179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData(int sender, int messageID, string text, bool endOfChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0010E400 File Offset: 0x0010C600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131186, RefRangeEnd = 131187, XrefRangeStart = 131181, XrefRangeEnd = 131186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0001AA05 File Offset: 0x00018C05
		public TextMessageData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0010E43C File Offset: 0x0010C63C
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0001AA0E File Offset: 0x00018C0E
		public unsafe int Sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender)) = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x0010E464 File Offset: 0x0010C664
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x0001AA29 File Offset: 0x00018C29
		public unsafe int MessageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID)) = value;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x0010E48C File Offset: 0x0010C68C
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x0001AA44 File Offset: 0x00018C44
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x0010E4B4 File Offset: 0x0010C6B4
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x0001AA63 File Offset: 0x00018C63
		public unsafe bool EndOfChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain)) = value;
			}
		}

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeFieldInfoPtr_Sender;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeFieldInfoPtr_MessageID;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr_EndOfChain;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
