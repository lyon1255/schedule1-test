using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D1 RID: 209
	public class VerticalBounce : MonoBehaviour
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x000A10A0 File Offset: 0x0009F2A0
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalBounce()
		{
			Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "VerticalBounce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr);
			VerticalBounce.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "acceleration");
			VerticalBounce.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "direction");
			VerticalBounce.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "y");
			VerticalBounce.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "speed");
			VerticalBounce.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, 100665092);
			VerticalBounce.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, 100665093);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000A1148 File Offset: 0x0009F348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86256, XrefRangeEnd = 86264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalBounce.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000A117C File Offset: 0x0009F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86264, XrefRangeEnd = 86265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalBounce() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalBounce.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00009B12 File Offset: 0x00007D12
		public VerticalBounce(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x000A11B8 File Offset: 0x0009F3B8
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00009B1B File Offset: 0x00007D1B
		public unsafe float acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_acceleration)) = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x000A11E0 File Offset: 0x0009F3E0
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00009B36 File Offset: 0x00007D36
		public unsafe float direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x000A1208 File Offset: 0x0009F408
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x00009B51 File Offset: 0x00007D51
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x000A1230 File Offset: 0x0009F430
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00009B6C File Offset: 0x00007D6C
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_acceleration;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
