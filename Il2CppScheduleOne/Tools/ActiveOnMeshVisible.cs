using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052B RID: 1323
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x0600763A RID: 30266 RVA: 0x002027D8 File Offset: 0x002009D8
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveOnMeshVisible()
		{
			Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveOnMeshVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr);
			ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Mesh");
			ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "ObjectsToActivate");
			ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Reverse");
			ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "isVisible");
			ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100678191);
			ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100678192);
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00202880 File Offset: 0x00200A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230598, XrefRangeEnd = 230604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x002028B4 File Offset: 0x00200AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230604, XrefRangeEnd = 230605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveOnMeshVisible() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x0003805A File Offset: 0x0003625A
		public ActiveOnMeshVisible(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x0600763E RID: 30270 RVA: 0x002028F0 File Offset: 0x00200AF0
		// (set) Token: 0x0600763F RID: 30271 RVA: 0x00038063 File Offset: 0x00036263
		public unsafe MeshRenderer Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x06007640 RID: 30272 RVA: 0x00202920 File Offset: 0x00200B20
		// (set) Token: 0x06007641 RID: 30273 RVA: 0x00038082 File Offset: 0x00036282
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x06007642 RID: 30274 RVA: 0x00202950 File Offset: 0x00200B50
		// (set) Token: 0x06007643 RID: 30275 RVA: 0x000380A1 File Offset: 0x000362A1
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x06007644 RID: 30276 RVA: 0x00202978 File Offset: 0x00200B78
		// (set) Token: 0x06007645 RID: 30277 RVA: 0x000380BC File Offset: 0x000362BC
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x040050C8 RID: 20680
		private static readonly IntPtr NativeFieldInfoPtr_Mesh;

		// Token: 0x040050C9 RID: 20681
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x040050CA RID: 20682
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x040050CB RID: 20683
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x040050CC RID: 20684
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040050CD RID: 20685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
