using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000A4 RID: 164
	public class MinMaxRangeAttribute : Attribute
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00094174 File Offset: 0x00092374
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxRangeAttribute()
		{
			Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MinMaxRangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr);
			MinMaxRangeAttribute.NativeFieldInfoPtr__minValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, "<minValue>k__BackingField");
			MinMaxRangeAttribute.NativeFieldInfoPtr__maxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, "<maxValue>k__BackingField");
			MinMaxRangeAttribute.NativeMethodInfoPtr_get_minValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664628);
			MinMaxRangeAttribute.NativeMethodInfoPtr_set_minValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664629);
			MinMaxRangeAttribute.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664630);
			MinMaxRangeAttribute.NativeMethodInfoPtr_set_maxValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664631);
			MinMaxRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664632);
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00094230 File Offset: 0x00092430
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0009426C File Offset: 0x0009246C
		public unsafe float minValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_get_minValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29949, RefRangeEnd = 29953, XrefRangeStart = 29949, XrefRangeEnd = 29953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_set_minValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000942AC File Offset: 0x000924AC
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x000942E8 File Offset: 0x000924E8
		public unsafe float maxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27828, RefRangeEnd = 27829, XrefRangeStart = 27828, XrefRangeEnd = 27829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_set_maxValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00094328 File Offset: 0x00092528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82659, XrefRangeEnd = 82660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxRangeAttribute(float min, float max) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00007B21 File Offset: 0x00005D21
		public MinMaxRangeAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00094380 File Offset: 0x00092580
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00007B2A File Offset: 0x00005D2A
		public unsafe float _minValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__minValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__minValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000943A8 File Offset: 0x000925A8
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00007B45 File Offset: 0x00005D45
		public unsafe float _maxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__maxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__maxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr__minValue_k__BackingField;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr__maxValue_k__BackingField;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_get_minValue_Public_get_Single_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_set_minValue_Private_set_Void_Single_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_Single_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_set_maxValue_Private_set_Void_Single_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
