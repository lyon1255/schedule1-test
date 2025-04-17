using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVolumetricFogAndMist2.Demos
{
	// Token: 0x020000C2 RID: 194
	public class FPS_Controller : MonoBehaviour
	{
		// Token: 0x06000E57 RID: 3671 RVA: 0x0009E754 File Offset: 0x0009C954
		// Note: this type is marked as 'beforefieldinit'.
		static FPS_Controller()
		{
			Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VolumetricFogAndMist2.Demos", "FPS_Controller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr);
			FPS_Controller.NativeFieldInfoPtr_characterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "characterController");
			FPS_Controller.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "mainCamera");
			FPS_Controller.NativeFieldInfoPtr_inputHor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "inputHor");
			FPS_Controller.NativeFieldInfoPtr_inputVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "inputVert");
			FPS_Controller.NativeFieldInfoPtr_mouseHor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "mouseHor");
			FPS_Controller.NativeFieldInfoPtr_mouseVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "mouseVert");
			FPS_Controller.NativeFieldInfoPtr_mouseInvertX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "mouseInvertX");
			FPS_Controller.NativeFieldInfoPtr_mouseInvertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "mouseInvertY");
			FPS_Controller.NativeFieldInfoPtr_camVertAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "camVertAngle");
			FPS_Controller.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "isGrounded");
			FPS_Controller.NativeFieldInfoPtr_jumpDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "jumpDirection");
			FPS_Controller.NativeFieldInfoPtr_sprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "sprint");
			FPS_Controller.NativeFieldInfoPtr_sprintMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "sprintMax");
			FPS_Controller.NativeFieldInfoPtr_airControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "airControl");
			FPS_Controller.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "jumpHeight");
			FPS_Controller.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "gravity");
			FPS_Controller.NativeFieldInfoPtr_characterHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "characterHeight");
			FPS_Controller.NativeFieldInfoPtr_cameraHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "cameraHeight");
			FPS_Controller.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "speed");
			FPS_Controller.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "rotationSpeed");
			FPS_Controller.NativeFieldInfoPtr_mouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, "mouseSensitivity");
			FPS_Controller.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, 100665042);
			FPS_Controller.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, 100665043);
			FPS_Controller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr, 100665044);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0009E964 File Offset: 0x0009CB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85734, XrefRangeEnd = 85759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPS_Controller.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0009E998 File Offset: 0x0009CB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85759, XrefRangeEnd = 85794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPS_Controller.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0009E9CC File Offset: 0x0009CBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85794, XrefRangeEnd = 85797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FPS_Controller() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPS_Controller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPS_Controller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00008F0F File Offset: 0x0000710F
		public FPS_Controller(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0009EA08 File Offset: 0x0009CC08
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00008F18 File Offset: 0x00007118
		public unsafe CharacterController characterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_characterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_characterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0009EA38 File Offset: 0x0009CC38
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00008F37 File Offset: 0x00007137
		public unsafe Transform mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0009EA68 File Offset: 0x0009CC68
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00008F56 File Offset: 0x00007156
		public unsafe float inputHor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_inputHor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_inputHor)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0009EA90 File Offset: 0x0009CC90
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00008F71 File Offset: 0x00007171
		public unsafe float inputVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_inputVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_inputVert)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0009EAB8 File Offset: 0x0009CCB8
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00008F8C File Offset: 0x0000718C
		public unsafe float mouseHor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseHor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseHor)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0009EAE0 File Offset: 0x0009CCE0
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00008FA7 File Offset: 0x000071A7
		public unsafe float mouseVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseVert)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0009EB08 File Offset: 0x0009CD08
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00008FC2 File Offset: 0x000071C2
		public unsafe float mouseInvertX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseInvertX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseInvertX)) = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0009EB30 File Offset: 0x0009CD30
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00008FDD File Offset: 0x000071DD
		public unsafe float mouseInvertY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseInvertY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseInvertY)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0009EB58 File Offset: 0x0009CD58
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00008FF8 File Offset: 0x000071F8
		public unsafe float camVertAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_camVertAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_camVertAngle)) = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0009EB80 File Offset: 0x0009CD80
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00009013 File Offset: 0x00007213
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0009EBA8 File Offset: 0x0009CDA8
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0000902E File Offset: 0x0000722E
		public unsafe Vector3 jumpDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_jumpDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_jumpDirection)) = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0009EBD0 File Offset: 0x0009CDD0
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00009049 File Offset: 0x00007249
		public unsafe float sprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_sprint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_sprint)) = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0009EBF8 File Offset: 0x0009CDF8
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00009064 File Offset: 0x00007264
		public unsafe float sprintMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_sprintMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_sprintMax)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0009EC20 File Offset: 0x0009CE20
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0000907F File Offset: 0x0000727F
		public unsafe float airControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_airControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_airControl)) = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0009EC48 File Offset: 0x0009CE48
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x0000909A File Offset: 0x0000729A
		public unsafe float jumpHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_jumpHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_jumpHeight)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0009EC70 File Offset: 0x0009CE70
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x000090B5 File Offset: 0x000072B5
		public unsafe float gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_gravity)) = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0009EC98 File Offset: 0x0009CE98
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x000090D0 File Offset: 0x000072D0
		public unsafe float characterHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_characterHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_characterHeight)) = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0009ECC0 File Offset: 0x0009CEC0
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x000090EB File Offset: 0x000072EB
		public unsafe float cameraHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_cameraHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_cameraHeight)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x0009ECE8 File Offset: 0x0009CEE8
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00009106 File Offset: 0x00007306
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0009ED10 File Offset: 0x0009CF10
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00009121 File Offset: 0x00007321
		public unsafe float rotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_rotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_rotationSpeed)) = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0009ED38 File Offset: 0x0009CF38
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0000913C File Offset: 0x0000733C
		public unsafe float mouseSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPS_Controller.NativeFieldInfoPtr_mouseSensitivity)) = value;
			}
		}

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeFieldInfoPtr_characterController;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr_mainCamera;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_inputHor;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_inputVert;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_mouseHor;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_mouseVert;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_mouseInvertX;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_mouseInvertY;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_camVertAngle;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr_jumpDirection;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_sprint;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_sprintMax;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeFieldInfoPtr_airControl;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_gravity;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_characterHeight;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_cameraHeight;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_mouseSensitivity;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
