using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A3 RID: 163
	[Serializable]
	[StructLayout(2)]
	public struct MinMaxRangeFloat
	{
		// Token: 0x06000B29 RID: 2857 RVA: 0x00093DB4 File Offset: 0x00091FB4
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxRangeFloat()
		{
			Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MinMaxRangeFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr);
			MinMaxRangeFloat.NativeFieldInfoPtr_m_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, "m_MinValue");
			MinMaxRangeFloat.NativeFieldInfoPtr_m_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, "m_MaxValue");
			MinMaxRangeFloat.NativeMethodInfoPtr_get_minValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664617);
			MinMaxRangeFloat.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664618);
			MinMaxRangeFloat.NativeMethodInfoPtr_get_randomValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664619);
			MinMaxRangeFloat.NativeMethodInfoPtr_get_asVector2_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664620);
			MinMaxRangeFloat.NativeMethodInfoPtr_GetLerpedValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664621);
			MinMaxRangeFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664622);
			MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664623);
			MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664624);
			MinMaxRangeFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664625);
			MinMaxRangeFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664626);
			MinMaxRangeFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664627);
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00093EE8 File Offset: 0x000920E8
		public unsafe float minValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_minValue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00093F18 File Offset: 0x00092118
		public unsafe float maxValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00093F48 File Offset: 0x00092148
		public unsafe float randomValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 36864, RefRangeEnd = 36866, XrefRangeStart = 36864, XrefRangeEnd = 36866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_randomValue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00093F78 File Offset: 0x00092178
		public unsafe Vector2 asVector2
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_asVector2_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00093FA8 File Offset: 0x000921A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82639, RefRangeEnd = 82640, XrefRangeStart = 82639, XrefRangeEnd = 82639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLerpedValue(float lerp01)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerp01;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_GetLerpedValue_Public_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00093FE8 File Offset: 0x000921E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 82640, RefRangeEnd = 82650, XrefRangeStart = 82640, XrefRangeEnd = 82640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxRangeFloat(float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00094028 File Offset: 0x00092228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82650, XrefRangeEnd = 82653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0009406C File Offset: 0x0009226C
		[CallerCount(0)]
		public unsafe bool Equals(MinMaxRangeFloat other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxRangeFloat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x000940AC File Offset: 0x000922AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82653, XrefRangeEnd = 82659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000940DC File Offset: 0x000922DC
		[CallerCount(0)]
		public unsafe static bool operator ==(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00094128 File Offset: 0x00092328
		[CallerCount(0)]
		public unsafe static bool operator !=(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00007B0F File Offset: 0x00005D0F
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, ref this));
		}

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_m_MinValue;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxValue;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_get_minValue_Public_get_Single_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_Single_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_get_randomValue_Public_get_Single_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_get_asVector2_Public_get_Vector2_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_GetLerpedValue_Public_Single_Single_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxRangeFloat_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0;

		// Token: 0x04000779 RID: 1913
		[FieldOffset(0)]
		public float m_MinValue;

		// Token: 0x0400077A RID: 1914
		[FieldOffset(4)]
		public float m_MaxValue;
	}
}
