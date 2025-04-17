using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046A RID: 1130
	[Serializable]
	public class StringIntPair : Object
	{
		// Token: 0x060061E6 RID: 25062 RVA: 0x001BDE58 File Offset: 0x001BC058
		// Note: this type is marked as 'beforefieldinit'.
		static StringIntPair()
		{
			Il2CppClassPointerStore<StringIntPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "StringIntPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr);
			StringIntPair.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "String");
			StringIntPair.NativeFieldInfoPtr_Int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "Int");
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100675726);
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100675727);
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x001BDED8 File Offset: 0x001BC0D8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 107228, RefRangeEnd = 107237, XrefRangeStart = 107228, XrefRangeEnd = 107237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair(string str, int i) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x001BDF34 File Offset: 0x001BC134
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x0002E429 File Offset: 0x0002C629
		public StringIntPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060061EA RID: 25066 RVA: 0x001BDF70 File Offset: 0x001BC170
		// (set) Token: 0x060061EB RID: 25067 RVA: 0x0002E432 File Offset: 0x0002C632
		public unsafe string String
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060061EC RID: 25068 RVA: 0x001BDF98 File Offset: 0x001BC198
		// (set) Token: 0x060061ED RID: 25069 RVA: 0x0002E451 File Offset: 0x0002C651
		public unsafe int Int
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int)) = value;
			}
		}

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeFieldInfoPtr_String;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeFieldInfoPtr_Int;

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x040042C6 RID: 17094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
