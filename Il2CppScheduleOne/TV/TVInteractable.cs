using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018F RID: 399
	public class TVInteractable : MonoBehaviour
	{
		// Token: 0x0600207C RID: 8316 RVA: 0x000D57B8 File Offset: 0x000D39B8
		// Note: this type is marked as 'beforefieldinit'.
		static TVInteractable()
		{
			Il2CppClassPointerStore<TVInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr);
			TVInteractable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, "IntObj");
			TVInteractable.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, "Interface");
			TVInteractable.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666924);
			TVInteractable.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666925);
			TVInteractable.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666926);
			TVInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666927);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000D5860 File Offset: 0x000D3A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108877, XrefRangeEnd = 108891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000D5894 File Offset: 0x000D3A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108891, XrefRangeEnd = 108892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000D58C8 File Offset: 0x000D3AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108892, XrefRangeEnd = 108893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000D58FC File Offset: 0x000D3AFC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000124CF File Offset: 0x000106CF
		public TVInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x000D5938 File Offset: 0x000D3B38
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x000124D8 File Offset: 0x000106D8
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x000D5968 File Offset: 0x000D3B68
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x000124F7 File Offset: 0x000106F7
		public unsafe TVInterface Interface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_Interface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
