using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000122 RID: 290
	[Serializable]
	public class SpherePoint : Il2CppSystem.Object
	{
		// Token: 0x060018A3 RID: 6307 RVA: 0x000BD474 File Offset: 0x000BB674
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePoint()
		{
			Il2CppClassPointerStore<SpherePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr);
			SpherePoint.NativeFieldInfoPtr_horizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "horizontalRotation");
			SpherePoint.NativeFieldInfoPtr_verticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "verticalRotation");
			SpherePoint.NativeFieldInfoPtr_MinHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MinHorizontalRotation");
			SpherePoint.NativeFieldInfoPtr_MaxHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MaxHorizontalRotation");
			SpherePoint.NativeFieldInfoPtr_MinVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MinVerticalRotation");
			SpherePoint.NativeFieldInfoPtr_MaxVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MaxVerticalRotation");
			SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665916);
			SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665917);
			SpherePoint.NativeMethodInfoPtr_SetFromWorldDirection_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665918);
			SpherePoint.NativeMethodInfoPtr_GetWorldDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665919);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000BD56C File Offset: 0x000BB76C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95681, RefRangeEnd = 95688, XrefRangeStart = 95680, XrefRangeEnd = 95681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint(float horizontalRotation, float verticalRotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref horizontalRotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000BD5C4 File Offset: 0x000BB7C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95690, RefRangeEnd = 95693, XrefRangeStart = 95688, XrefRangeEnd = 95690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint(Vector3 worldDirection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000BD60C File Offset: 0x000BB80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95693, XrefRangeEnd = 95694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFromWorldDirection(Vector3 worldDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr_SetFromWorldDirection_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000BD64C File Offset: 0x000BB84C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95698, RefRangeEnd = 95705, XrefRangeStart = 95694, XrefRangeEnd = 95698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWorldDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr_GetWorldDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0000E268 File Offset: 0x0000C468
		public SpherePoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x000BD688 File Offset: 0x000BB888
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000E271 File Offset: 0x0000C471
		public unsafe float horizontalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_horizontalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_horizontalRotation)) = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x000BD6B0 File Offset: 0x000BB8B0
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000E28C File Offset: 0x0000C48C
		public unsafe float verticalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_verticalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_verticalRotation)) = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x000BD6D8 File Offset: 0x000BB8D8
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000E2A7 File Offset: 0x0000C4A7
		public unsafe static float MinHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x000BD6F4 File Offset: 0x000BB8F4
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0000E2B5 File Offset: 0x0000C4B5
		public unsafe static float MaxHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x000BD710 File Offset: 0x000BB910
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0000E2C3 File Offset: 0x0000C4C3
		public unsafe static float MinVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x000BD72C File Offset: 0x000BB92C
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x0000E2D1 File Offset: 0x0000C4D1
		public unsafe static float MaxVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr_horizontalRotation;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr_verticalRotation;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_MinHorizontalRotation;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_MaxHorizontalRotation;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr_MinVerticalRotation;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr_MaxVerticalRotation;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_SetFromWorldDirection_Public_Void_Vector3_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldDirection_Public_Vector3_0;
	}
}
