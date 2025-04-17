using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BD RID: 189
	public class FreeCameraController : MonoBehaviour
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x0009DBE8 File Offset: 0x0009BDE8
		// Note: this type is marked as 'beforefieldinit'.
		static FreeCameraController()
		{
			Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "FreeCameraController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr);
			FreeCameraController.NativeFieldInfoPtr_cameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "cameraSensitivity");
			FreeCameraController.NativeFieldInfoPtr_speedNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedNormal");
			FreeCameraController.NativeFieldInfoPtr_speedFactorSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedFactorSlow");
			FreeCameraController.NativeFieldInfoPtr_speedFactorFast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedFactorFast");
			FreeCameraController.NativeFieldInfoPtr_speedClimb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedClimb");
			FreeCameraController.NativeFieldInfoPtr_rotationH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "rotationH");
			FreeCameraController.NativeFieldInfoPtr_rotationV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "rotationV");
			FreeCameraController.NativeFieldInfoPtr_m_UseMouseView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "m_UseMouseView");
			FreeCameraController.NativeMethodInfoPtr_get_useMouseView_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100665027);
			FreeCameraController.NativeMethodInfoPtr_set_useMouseView_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100665028);
			FreeCameraController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100665029);
			FreeCameraController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100665030);
			FreeCameraController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100665031);
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0009DD1C File Offset: 0x0009BF1C
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0009DD58 File Offset: 0x0009BF58
		public unsafe bool useMouseView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_get_useMouseView_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85516, XrefRangeEnd = 85518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_set_useMouseView_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0009DD98 File Offset: 0x0009BF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85518, XrefRangeEnd = 85524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0009DDCC File Offset: 0x0009BFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85524, XrefRangeEnd = 85588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0009DE00 File Offset: 0x0009C000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85588, XrefRangeEnd = 85589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeCameraController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00008C2F File Offset: 0x00006E2F
		public FreeCameraController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0009DE3C File Offset: 0x0009C03C
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00008C38 File Offset: 0x00006E38
		public unsafe float cameraSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_cameraSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_cameraSensitivity)) = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0009DE64 File Offset: 0x0009C064
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00008C53 File Offset: 0x00006E53
		public unsafe float speedNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedNormal)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0009DE8C File Offset: 0x0009C08C
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00008C6E File Offset: 0x00006E6E
		public unsafe float speedFactorSlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorSlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorSlow)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0009DEB4 File Offset: 0x0009C0B4
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00008C89 File Offset: 0x00006E89
		public unsafe float speedFactorFast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorFast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorFast)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0009DEDC File Offset: 0x0009C0DC
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00008CA4 File Offset: 0x00006EA4
		public unsafe float speedClimb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedClimb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedClimb)) = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0009DF04 File Offset: 0x0009C104
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00008CBF File Offset: 0x00006EBF
		public unsafe float rotationH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationH)) = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0009DF2C File Offset: 0x0009C12C
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00008CDA File Offset: 0x00006EDA
		public unsafe float rotationV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationV)) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0009DF54 File Offset: 0x0009C154
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00008CF5 File Offset: 0x00006EF5
		public unsafe bool m_UseMouseView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_m_UseMouseView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_m_UseMouseView)) = value;
			}
		}

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_cameraSensitivity;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_speedNormal;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_speedFactorSlow;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_speedFactorFast;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeFieldInfoPtr_speedClimb;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeFieldInfoPtr_rotationH;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeFieldInfoPtr_rotationV;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeFieldInfoPtr_m_UseMouseView;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_get_useMouseView_Private_get_Boolean_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_set_useMouseView_Private_set_Void_Boolean_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
