using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000605 RID: 1541
	public class EmotionOverride : Object
	{
		// Token: 0x060087D8 RID: 34776 RVA: 0x0023CD80 File Offset: 0x0023AF80
		// Note: this type is marked as 'beforefieldinit'.
		static EmotionOverride()
		{
			Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "EmotionOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr);
			EmotionOverride.NativeFieldInfoPtr_Emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Emotion");
			EmotionOverride.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Label");
			EmotionOverride.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Priority");
			EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, 100680230);
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x0023CE00 File Offset: 0x0023B000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride(string emotion, string label, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x00040BB2 File Offset: 0x0003EDB2
		public EmotionOverride(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x060087DB RID: 34779 RVA: 0x0023CE6C File Offset: 0x0023B06C
		// (set) Token: 0x060087DC RID: 34780 RVA: 0x00040BBB File Offset: 0x0003EDBB
		public unsafe string Emotion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x060087DD RID: 34781 RVA: 0x0023CE94 File Offset: 0x0023B094
		// (set) Token: 0x060087DE RID: 34782 RVA: 0x00040BDA File Offset: 0x0003EDDA
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x060087DF RID: 34783 RVA: 0x0023CEBC File Offset: 0x0023B0BC
		// (set) Token: 0x060087E0 RID: 34784 RVA: 0x00040BF9 File Offset: 0x0003EDF9
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x04005C57 RID: 23639
		private static readonly IntPtr NativeFieldInfoPtr_Emotion;

		// Token: 0x04005C58 RID: 23640
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005C59 RID: 23641
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04005C5A RID: 23642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
	}
}
