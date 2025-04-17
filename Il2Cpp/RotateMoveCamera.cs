using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000029 RID: 41
	public class RotateMoveCamera : MonoBehaviour
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x000793F4 File Offset: 0x000775F4
		// Note: this type is marked as 'beforefieldinit'.
		static RotateMoveCamera()
		{
			Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RotateMoveCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr);
			RotateMoveCamera.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "Camera");
			RotateMoveCamera.NativeFieldInfoPtr_minX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "minX");
			RotateMoveCamera.NativeFieldInfoPtr_maxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "maxX");
			RotateMoveCamera.NativeFieldInfoPtr_minY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "minY");
			RotateMoveCamera.NativeFieldInfoPtr_maxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "maxY");
			RotateMoveCamera.NativeFieldInfoPtr_sensX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "sensX");
			RotateMoveCamera.NativeFieldInfoPtr_sensY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "sensY");
			RotateMoveCamera.NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "rotationY");
			RotateMoveCamera.NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "rotationX");
			RotateMoveCamera.NativeFieldInfoPtr_MouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "MouseX");
			RotateMoveCamera.NativeFieldInfoPtr_MouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, "MouseY");
			RotateMoveCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, 100663563);
			RotateMoveCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr, 100663564);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00079528 File Offset: 0x00077728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72779, XrefRangeEnd = 72799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateMoveCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0007955C File Offset: 0x0007775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72799, XrefRangeEnd = 72800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateMoveCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateMoveCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateMoveCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000039B1 File Offset: 0x00001BB1
		public RotateMoveCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00079598 File Offset: 0x00077798
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000039BA File Offset: 0x00001BBA
		public unsafe GameObject Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000795C8 File Offset: 0x000777C8
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000039D9 File Offset: 0x00001BD9
		public unsafe float minX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_minX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_minX)) = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000795F0 File Offset: 0x000777F0
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000039F4 File Offset: 0x00001BF4
		public unsafe float maxX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_maxX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_maxX)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00079618 File Offset: 0x00077818
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003A0F File Offset: 0x00001C0F
		public unsafe float minY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_minY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_minY)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00079640 File Offset: 0x00077840
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003A2A File Offset: 0x00001C2A
		public unsafe float maxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_maxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_maxY)) = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00079668 File Offset: 0x00077868
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003A45 File Offset: 0x00001C45
		public unsafe float sensX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_sensX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_sensX)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00079690 File Offset: 0x00077890
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00003A60 File Offset: 0x00001C60
		public unsafe float sensY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_sensY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_sensY)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000796B8 File Offset: 0x000778B8
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00003A7B File Offset: 0x00001C7B
		public unsafe float rotationY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_rotationY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_rotationY)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000796E0 File Offset: 0x000778E0
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00003A96 File Offset: 0x00001C96
		public unsafe float rotationX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_rotationX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_rotationX)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00079708 File Offset: 0x00077908
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00003AB1 File Offset: 0x00001CB1
		public unsafe float MouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_MouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_MouseX)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00079730 File Offset: 0x00077930
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003ACC File Offset: 0x00001CCC
		public unsafe float MouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_MouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateMoveCamera.NativeFieldInfoPtr_MouseY)) = value;
			}
		}

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_minX;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_maxX;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_minY;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_maxY;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_sensX;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_sensY;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_rotationY;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_rotationX;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_MouseX;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_MouseY;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
