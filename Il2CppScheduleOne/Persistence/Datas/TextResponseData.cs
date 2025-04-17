using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public class TextResponseData : Object
	{
		// Token: 0x060031C9 RID: 12745 RVA: 0x0010E4DC File Offset: 0x0010C6DC
		// Note: this type is marked as 'beforefieldinit'.
		static TextResponseData()
		{
			Il2CppClassPointerStore<TextResponseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextResponseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr);
			TextResponseData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Text");
			TextResponseData.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Label");
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100668850);
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100668851);
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0010E55C File Offset: 0x0010C75C
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110661, RefRangeEnd = 110710, XrefRangeStart = 110661, XrefRangeEnd = 110710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData(string text, string label) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x0010E5BC File Offset: 0x0010C7BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131195, RefRangeEnd = 131196, XrefRangeStart = 131187, XrefRangeEnd = 131195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x0001AA7E File Offset: 0x00018C7E
		public TextResponseData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0010E5F8 File Offset: 0x0010C7F8
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x0001AA87 File Offset: 0x00018C87
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x0010E620 File Offset: 0x0010C820
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x0001AAA6 File Offset: 0x00018CA6
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
