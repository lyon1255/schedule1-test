using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001AA RID: 426
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06002419 RID: 9241 RVA: 0x000E0728 File Offset: 0x000DE928
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardVisuals()
		{
			Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr);
			SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "MaxBoardLean");
			SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "BoardLeanRate");
			SkateboardVisuals.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "Board");
			SkateboardVisuals.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "skateboard");
			SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667295);
			SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667296);
			SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667297);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000E07E4 File Offset: 0x000DE9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112869, XrefRangeEnd = 112873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x000E0818 File Offset: 0x000DEA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112873, XrefRangeEnd = 112878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x000E084C File Offset: 0x000DEA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112878, XrefRangeEnd = 112879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x000144C4 File Offset: 0x000126C4
		public SkateboardVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000E0888 File Offset: 0x000DEA88
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x000144CD File Offset: 0x000126CD
		public unsafe float MaxBoardLean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean)) = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x000E08B0 File Offset: 0x000DEAB0
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x000144E8 File Offset: 0x000126E8
		public unsafe float BoardLeanRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate)) = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x000E08D8 File Offset: 0x000DEAD8
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x00014503 File Offset: 0x00012703
		public unsafe Transform Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x000E0908 File Offset: 0x000DEB08
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x00014522 File Offset: 0x00012722
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoardLean;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeFieldInfoPtr_BoardLeanRate;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
