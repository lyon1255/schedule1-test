using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000134 RID: 308
	public class HelpBoxAttribute : PropertyAttribute
	{
		// Token: 0x06001A1A RID: 6682 RVA: 0x000C2148 File Offset: 0x000C0348
		// Note: this type is marked as 'beforefieldinit'.
		static HelpBoxAttribute()
		{
			Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "HelpBoxAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr);
			HelpBoxAttribute.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr, "text");
			HelpBoxAttribute.NativeFieldInfoPtr_messageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr, "messageType");
			HelpBoxAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr, 100666064);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000C21B4 File Offset: 0x000C03B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96921, XrefRangeEnd = 96923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpBoxAttribute(string text, HelpBoxMessageType messageType = HelpBoxMessageType.None) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBoxAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		public HelpBoxAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x000C2210 File Offset: 0x000C0410
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x0000EDA9 File Offset: 0x0000CFA9
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x000C2238 File Offset: 0x000C0438
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		public unsafe HelpBoxMessageType messageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_messageType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_messageType)) = value;
			}
		}

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeFieldInfoPtr_messageType;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0;
	}
}
