using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BB RID: 955
	[Serializable]
	[StructLayout(2)]
	public struct FullRank
	{
		// Token: 0x06004A58 RID: 19032 RVA: 0x00168978 File Offset: 0x00166B78
		// Note: this type is marked as 'beforefieldinit'.
		static FullRank()
		{
			Il2CppClassPointerStore<FullRank>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "FullRank");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullRank>.NativeClassPtr);
			FullRank.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Rank");
			FullRank.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Tier");
			FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672509);
			FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672510);
			FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672511);
			FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672512);
			FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672513);
			FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672514);
			FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672515);
			FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672516);
			FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672517);
			FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672518);
			FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672519);
			FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672520);
			FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672521);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00168AD4 File Offset: 0x00166CD4
		[CallerCount(93)]
		[CachedScanResults(RefRangeStart = 34314, RefRangeEnd = 34407, XrefRangeStart = 34314, XrefRangeEnd = 34407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank(ERank rank, int tier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00168B14 File Offset: 0x00166D14
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 163888, RefRangeEnd = 163897, XrefRangeStart = 163872, XrefRangeEnd = 163888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00168B40 File Offset: 0x00166D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163897, RefRangeEnd = 163899, XrefRangeStart = 163897, XrefRangeEnd = 163897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank NextRank()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00168B70 File Offset: 0x00166D70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163915, RefRangeEnd = 163918, XrefRangeStart = 163899, XrefRangeEnd = 163915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(FullRank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00168BA8 File Offset: 0x00166DA8
		[CallerCount(0)]
		public unsafe static bool operator >(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00168BF4 File Offset: 0x00166DF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163918, RefRangeEnd = 163920, XrefRangeStart = 163918, XrefRangeEnd = 163918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00168C40 File Offset: 0x00166E40
		[CallerCount(0)]
		public unsafe static bool operator <=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00168C8C File Offset: 0x00166E8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163920, RefRangeEnd = 163924, XrefRangeStart = 163920, XrefRangeEnd = 163920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00168CD8 File Offset: 0x00166ED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58810, RefRangeEnd = 58812, XrefRangeStart = 58810, XrefRangeEnd = 58812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00168D24 File Offset: 0x00166F24
		[CallerCount(0)]
		public unsafe static bool operator !=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00168D70 File Offset: 0x00166F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163924, XrefRangeEnd = 163927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00168DB4 File Offset: 0x00166FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163927, XrefRangeEnd = 163931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00168DE4 File Offset: 0x00166FE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163931, RefRangeEnd = 163933, XrefRangeStart = 163931, XrefRangeEnd = 163931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FullRank other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00023DEE File Offset: 0x00021FEE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullRank>.NativeClassPtr, ref this));
		}

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeMethodInfoPtr_NextRank_Public_FullRank_0;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0;

		// Token: 0x04003222 RID: 12834
		[FieldOffset(0)]
		public ERank Rank;

		// Token: 0x04003223 RID: 12835
		[FieldOffset(4)]
		public int Tier;
	}
}
