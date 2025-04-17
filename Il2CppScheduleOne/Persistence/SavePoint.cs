using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000221 RID: 545
	public class SavePoint : MonoBehaviour
	{
		// Token: 0x06002D8F RID: 11663 RVA: 0x00101390 File Offset: 0x000FF590
		// Note: this type is marked as 'beforefieldinit'.
		static SavePoint()
		{
			Il2CppClassPointerStore<SavePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SavePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavePoint>.NativeClassPtr);
			SavePoint.NativeFieldInfoPtr_SAVE_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "SAVE_COOLDOWN");
			SavePoint.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "IntObj");
			SavePoint.NativeFieldInfoPtr_onSaveStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "onSaveStart");
			SavePoint.NativeFieldInfoPtr_onSaveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "onSaveComplete");
			SavePoint.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668515);
			SavePoint.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668516);
			SavePoint.NativeMethodInfoPtr_CanSave_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668517);
			SavePoint.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668518);
			SavePoint.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668519);
			SavePoint.NativeMethodInfoPtr_OnSaveComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668520);
			SavePoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668521);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x0010149C File Offset: 0x000FF69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127046, XrefRangeEnd = 127060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x001014D0 File Offset: 0x000FF6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127060, XrefRangeEnd = 127072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00101504 File Offset: 0x000FF704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127084, RefRangeEnd = 127086, XrefRangeStart = 127072, XrefRangeEnd = 127084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSave(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_CanSave_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x0010155C File Offset: 0x000FF75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127086, XrefRangeEnd = 127088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00101590 File Offset: 0x000FF790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127112, RefRangeEnd = 127113, XrefRangeStart = 127088, XrefRangeEnd = 127112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x001015C4 File Offset: 0x000FF7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127113, XrefRangeEnd = 127114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSaveComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_OnSaveComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x001015F8 File Offset: 0x000FF7F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SavePoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavePoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x0001873A File Offset: 0x0001693A
		public SavePoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00101634 File Offset: 0x000FF834
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00018743 File Offset: 0x00016943
		public unsafe static float SAVE_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SavePoint.NativeFieldInfoPtr_SAVE_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SavePoint.NativeFieldInfoPtr_SAVE_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00101650 File Offset: 0x000FF850
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00018751 File Offset: 0x00016951
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00101680 File Offset: 0x000FF880
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x00018770 File Offset: 0x00016970
		public unsafe UnityEvent onSaveStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x001016B0 File Offset: 0x000FF8B0
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x0001878F File Offset: 0x0001698F
		public unsafe UnityEvent onSaveComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_COOLDOWN;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeFieldInfoPtr_onSaveStart;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeFieldInfoPtr_onSaveComplete;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_CanSave_Private_Boolean_byref_String_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_OnSaveComplete_Public_Void_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
