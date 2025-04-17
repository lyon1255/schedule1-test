using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004DA RID: 1242
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x06006C7E RID: 27774 RVA: 0x001E18F8 File Offset: 0x001DFAF8
		// Note: this type is marked as 'beforefieldinit'.
		static StartLoopStopAudio()
		{
			Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "StartLoopStopAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr);
			StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "<Runnning>k__BackingField");
			StartLoopStopAudio.NativeFieldInfoPtr_StartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "StartSound");
			StartLoopStopAudio.NativeFieldInfoPtr_LoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "LoopSound");
			StartLoopStopAudio.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "StopSound");
			StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "FadeLoopIn");
			StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "FadeLoopOut");
			StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "timeSinceStart");
			StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "timeSinceStop");
			StartLoopStopAudio.NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677013);
			StartLoopStopAudio.NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677014);
			StartLoopStopAudio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677015);
			StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677016);
			StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677017);
			StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677018);
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x001E1A40 File Offset: 0x001DFC40
		// (set) Token: 0x06006C80 RID: 27776 RVA: 0x001E1A7C File Offset: 0x001DFC7C
		public unsafe bool Runnning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x001E1ABC File Offset: 0x001DFCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216993, XrefRangeEnd = 217000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x001E1AF0 File Offset: 0x001DFCF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217001, RefRangeEnd = 217004, XrefRangeStart = 217000, XrefRangeEnd = 217001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x001E1B24 File Offset: 0x001DFD24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217005, RefRangeEnd = 217008, XrefRangeStart = 217004, XrefRangeEnd = 217005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x001E1B58 File Offset: 0x001DFD58
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLoopStopAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x000335B0 File Offset: 0x000317B0
		public StartLoopStopAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x001E1B94 File Offset: 0x001DFD94
		// (set) Token: 0x06006C87 RID: 27783 RVA: 0x000335B9 File Offset: 0x000317B9
		public unsafe bool _Runnning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField)) = value;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x001E1BBC File Offset: 0x001DFDBC
		// (set) Token: 0x06006C89 RID: 27785 RVA: 0x000335D4 File Offset: 0x000317D4
		public unsafe AudioSourceController StartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001E1BEC File Offset: 0x001DFDEC
		// (set) Token: 0x06006C8B RID: 27787 RVA: 0x000335F3 File Offset: 0x000317F3
		public unsafe AudioSourceController LoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_LoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_LoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x001E1C1C File Offset: 0x001DFE1C
		// (set) Token: 0x06006C8D RID: 27789 RVA: 0x00033612 File Offset: 0x00031812
		public unsafe AudioSourceController StopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06006C8E RID: 27790 RVA: 0x001E1C4C File Offset: 0x001DFE4C
		// (set) Token: 0x06006C8F RID: 27791 RVA: 0x00033631 File Offset: 0x00031831
		public unsafe bool FadeLoopIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn)) = value;
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06006C90 RID: 27792 RVA: 0x001E1C74 File Offset: 0x001DFE74
		// (set) Token: 0x06006C91 RID: 27793 RVA: 0x0003364C File Offset: 0x0003184C
		public unsafe bool FadeLoopOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut)) = value;
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06006C92 RID: 27794 RVA: 0x001E1C9C File Offset: 0x001DFE9C
		// (set) Token: 0x06006C93 RID: 27795 RVA: 0x00033667 File Offset: 0x00031867
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06006C94 RID: 27796 RVA: 0x001E1CC4 File Offset: 0x001DFEC4
		// (set) Token: 0x06006C95 RID: 27797 RVA: 0x00033682 File Offset: 0x00031882
		public unsafe float timeSinceStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop)) = value;
			}
		}

		// Token: 0x04004A2A RID: 18986
		private static readonly IntPtr NativeFieldInfoPtr__Runnning_k__BackingField;

		// Token: 0x04004A2B RID: 18987
		private static readonly IntPtr NativeFieldInfoPtr_StartSound;

		// Token: 0x04004A2C RID: 18988
		private static readonly IntPtr NativeFieldInfoPtr_LoopSound;

		// Token: 0x04004A2D RID: 18989
		private static readonly IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x04004A2E RID: 18990
		private static readonly IntPtr NativeFieldInfoPtr_FadeLoopIn;

		// Token: 0x04004A2F RID: 18991
		private static readonly IntPtr NativeFieldInfoPtr_FadeLoopOut;

		// Token: 0x04004A30 RID: 18992
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x04004A31 RID: 18993
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStop;

		// Token: 0x04004A32 RID: 18994
		private static readonly IntPtr NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0;

		// Token: 0x04004A33 RID: 18995
		private static readonly IntPtr NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0;

		// Token: 0x04004A34 RID: 18996
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004A35 RID: 18997
		private static readonly IntPtr NativeMethodInfoPtr_StartAudio_Public_Void_0;

		// Token: 0x04004A36 RID: 18998
		private static readonly IntPtr NativeMethodInfoPtr_StopAudio_Public_Void_0;

		// Token: 0x04004A37 RID: 18999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
