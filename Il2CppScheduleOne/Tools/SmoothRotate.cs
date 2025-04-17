using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000551 RID: 1361
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x060077F7 RID: 30711 RVA: 0x002078D4 File Offset: 0x00205AD4
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothRotate()
		{
			Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothRotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr);
			SmoothRotate.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Active");
			SmoothRotate.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Speed");
			SmoothRotate.NativeFieldInfoPtr_Aceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Aceleration");
			SmoothRotate.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Axis");
			SmoothRotate.NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "currentSpeed");
			SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678387);
			SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678388);
			SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678389);
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x002079A4 File Offset: 0x00205BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232148, XrefRangeEnd = 232155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x002079D8 File Offset: 0x00205BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00207A18 File Offset: 0x00205C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232155, XrefRangeEnd = 232158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothRotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00038D6C File Offset: 0x00036F6C
		public SmoothRotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x060077FC RID: 30716 RVA: 0x00207A54 File Offset: 0x00205C54
		// (set) Token: 0x060077FD RID: 30717 RVA: 0x00038D75 File Offset: 0x00036F75
		public unsafe bool Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active)) = value;
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x060077FE RID: 30718 RVA: 0x00207A7C File Offset: 0x00205C7C
		// (set) Token: 0x060077FF RID: 30719 RVA: 0x00038D90 File Offset: 0x00036F90
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x06007800 RID: 30720 RVA: 0x00207AA4 File Offset: 0x00205CA4
		// (set) Token: 0x06007801 RID: 30721 RVA: 0x00038DAB File Offset: 0x00036FAB
		public unsafe float Aceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration)) = value;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x06007802 RID: 30722 RVA: 0x00207ACC File Offset: 0x00205CCC
		// (set) Token: 0x06007803 RID: 30723 RVA: 0x00038DC6 File Offset: 0x00036FC6
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x06007804 RID: 30724 RVA: 0x00207AF4 File Offset: 0x00205CF4
		// (set) Token: 0x06007805 RID: 30725 RVA: 0x00038DE1 File Offset: 0x00036FE1
		public unsafe float currentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed)) = value;
			}
		}

		// Token: 0x040051CE RID: 20942
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x040051CF RID: 20943
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040051D0 RID: 20944
		private static readonly IntPtr NativeFieldInfoPtr_Aceleration;

		// Token: 0x040051D1 RID: 20945
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040051D2 RID: 20946
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeed;

		// Token: 0x040051D3 RID: 20947
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040051D4 RID: 20948
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040051D5 RID: 20949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
